namespace YogevDbShenkar
{
    partial class Connection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shenkar DB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter credentials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Server name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "password";
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(312, 242);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(287, 38);
            this.Server.TabIndex = 8;
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(312, 314);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(287, 38);
            this.Database.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(312, 381);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(287, 38);
            this.ID.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(312, 443);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(287, 38);
            this.password.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connection
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connection";
            this.Text = "Connection to DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
    }
}

