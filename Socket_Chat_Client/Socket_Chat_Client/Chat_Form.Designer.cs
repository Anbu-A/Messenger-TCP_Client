namespace Socket_Chat_Client
{
    partial class Chat_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.chat_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 630);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(368, 20);
            this.input_textbox.TabIndex = 0;
            this.input_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // chat_textbox
            // 
            this.chat_textbox.BackColor = System.Drawing.Color.Cornsilk;
            this.chat_textbox.Location = new System.Drawing.Point(13, 13);
            this.chat_textbox.Multiline = true;
            this.chat_textbox.Name = "chat_textbox";
            this.chat_textbox.ReadOnly = true;
            this.chat_textbox.Size = new System.Drawing.Size(367, 611);
            this.chat_textbox.TabIndex = 1;
            // 
            // Chat_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 662);
            this.Controls.Add(this.chat_textbox);
            this.Controls.Add(this.input_textbox);
            this.Name = "Chat_Form";
            this.Text = "Chatbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_Form_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.TextBox chat_textbox;
    }
}
