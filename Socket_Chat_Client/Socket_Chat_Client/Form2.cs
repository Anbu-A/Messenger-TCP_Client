using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Extras for this Project
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Socket_Chat_Client
{
    public partial class Chat_Form : Form
    {
        String user_name;
        Socket socket;
        String msg = "";
        Thread recv_thread;
        Login_Form login_form = null;
        const String DC_COMMAND = "/dc";


        public Chat_Form(Socket soc, String usr_n)
        {
            InitializeComponent();
            socket = soc;
            user_name = usr_n;
        }

       
        private void Chat_Form_Load(object sender, EventArgs e)
        {
            send_message(user_name);

            recv_thread = new Thread(receive_message);
            recv_thread.Start();
        }


        private delegate void SafeCallDelegate(string text);
        private void write_text_safe(string text)
        {
            if (textBox2.InvokeRequired)
            {
                var d = new SafeCallDelegate(write_text_safe);
                textBox2.Invoke(d, new object[] { text });
            }
            else
            {
                textBox2.Text = text;
            }
        }


        private void receive_message()
        {
            byte[] buffer = new byte[1024];
            int byte_received = 0;
            String msg = "";
            bool error = false;

            while (true)
            {
                try
                {
                    byte_received = socket.Receive(buffer);
                }
                catch (System.Net.Sockets.SocketException exc)
                {
                    MessageBox.Show(exc.Message);
                    error = true;
                }
                catch (System.ObjectDisposedException exc)
                {
                    MessageBox.Show(exc.Message);
                    error = true;
                }

                if (error)
                {              
                    switch_window();
                }
                else
                {
                    if (byte_received != 0)
                    {
                        msg += Encoding.ASCII.GetString(buffer, 0, byte_received) + Environment.NewLine;
                        write_text_safe(msg);
                    }
                }
            }
        }


        private void send_message(String msg)
        {
            byte[] msg_byte_format = Encoding.ASCII.GetBytes(msg);
            socket.Send(msg_byte_format);
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // To prevent the "ding" sound when pressing enter
                // Credits: https://stackoverflow.com/questions/6290967/stop-the-ding-when-pressing-enter , user: Mawardy
                e.Handled = true;

                msg = textBox1.Text;
                textBox2.Text += $"[{user_name}]: {msg}" + Environment.NewLine;

                if (msg == DC_COMMAND)
                {
                    switch_window();
                }
                else
                {
                    send_message(msg);

                    msg = "";
                    textBox1.Text = "";
                }
            }
        }


        private void switch_window()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(switch_window));
            }
            else
            {
                // Switch from Form2 to Form1
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(this.Hide));
                }
                else
                {
                    this.Hide();
                }

                if (login_form == null)
                {
                    login_form = new Login_Form();
                }
                login_form.Show();
                close_client_con();
            }

        }


        private void close_client_con()
        {
            try
            {
                if (socket != null)
                    socket.Shutdown(SocketShutdown.Both);
            }
            catch (System.ObjectDisposedException)
            {
                Console.WriteLine("Already closed");
            }
            catch (System.Net.Sockets.SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (recv_thread != null)
                    recv_thread.Abort();

                if (socket != null)
                    socket.Close();
            }
        }

        private void Chat_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            close_client_con();
            Application.Exit();
        }
    }
}
