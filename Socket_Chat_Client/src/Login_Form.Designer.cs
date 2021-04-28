namespace Socket_Chat_Client
{
    partial class Login_Form
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.ip_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(12, 74);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(404, 20);
            this.ip_textbox.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(175, 9);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(69, 23);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_label.Location = new System.Drawing.Point(13, 52);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(29, 19);
            this.ip_label.TabIndex = 2;
            this.ip_label.Text = "IP:";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_label.Location = new System.Drawing.Point(13, 116);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(55, 19);
            this.port_label.TabIndex = 3;
            this.port_label.Text = "PORT:";
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(12, 138);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(100, 20);
            this.port_textbox.TabIndex = 4;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(8, 202);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(80, 19);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username:";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(12, 224);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 6;
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_button.Location = new System.Drawing.Point(160, 244);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(103, 35);
            this.connect_button.TabIndex = 7;
            this.connect_button.Text = "CONNECT";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 291);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.ip_textbox);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Button connect_button;
    }
}
