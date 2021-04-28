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

namespace Socket_Chat_Client
{
    public partial class Login_Form : Form
    {
        String ip_address;
        int port;
        bool error_on_connection;
        IPEndPoint ip_end_point;
        String user_name;
        Socket socket = null;
        Chat_Form chat_form = null;
        public static Login_Form instance;

        public Login_Form()
        {
            InitializeComponent();
            instance = this;

            // Später weg machen nur weil faul
            ip_textbox.Text = "127.0.0.1";
            port_textbox.Text = "9999";
            username_textbox.Text = "achi";
        }


        private void connect_button_Click(object sender, EventArgs e)
        {
            ip_address = ip_textbox.Text;
            port = Int32.Parse(port_textbox.Text);
            user_name = username_textbox.Text;


            error_on_connection = false;
            // Setup for the connection
            try
            {
                ip_end_point = new IPEndPoint(IPAddress.Parse(ip_address), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (System.FormatException exc)
            {
                error_on_connection = true;
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message);
            }
            catch (System.ArgumentOutOfRangeException exc)
            {
                error_on_connection = true;
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message);
            }

            // Connection 
            try
            {
                if (socket != null)
                {
                    socket.Connect(ip_end_point);
                }
            }
            catch (System.Net.Sockets.SocketException exc)
            {
                error_on_connection = true;
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message);
            }
            catch (System.NullReferenceException exc)
            {
                error_on_connection = true;
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message);
            }

            if (error_on_connection)
            {
                MessageBox.Show("Something went wrong please enter your details again");
            }
            else
            {
                // Switch from Form1 to Form2
                this.Hide();
                if (chat_form == null)
                {
                    chat_form = new Chat_Form(socket, user_name);
                }
                chat_form.Show();
            }
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
