namespace AryaSoft
{
    partial class Form1
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
            this.Server_txt = new System.Windows.Forms.TextBox();
            this.Database_txt = new System.Windows.Forms.TextBox();
            this.WindowsRadio = new System.Windows.Forms.RadioButton();
            this.SqlRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Path_txt = new System.Windows.Forms.TextBox();
            this.btn_sec = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_yedekle = new System.Windows.Forms.Button();
            this.btnconnection = new System.Windows.Forms.Button();
            this.rdatabase = new System.Windows.Forms.TextBox();
            this.rserver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrestoresec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RSql_radio = new System.Windows.Forms.RadioButton();
            this.Rwindows_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // Server_txt
            // 
            this.Server_txt.Location = new System.Drawing.Point(103, 263);
            this.Server_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Server_txt.Name = "Server_txt";
            this.Server_txt.Size = new System.Drawing.Size(132, 22);
            this.Server_txt.TabIndex = 2;
            // 
            // Database_txt
            // 
            this.Database_txt.Location = new System.Drawing.Point(103, 311);
            this.Database_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Database_txt.Name = "Database_txt";
            this.Database_txt.Size = new System.Drawing.Size(132, 22);
            this.Database_txt.TabIndex = 3;
            // 
            // WindowsRadio
            // 
            this.WindowsRadio.AutoSize = true;
            this.WindowsRadio.Location = new System.Drawing.Point(38, 194);
            this.WindowsRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WindowsRadio.Name = "WindowsRadio";
            this.WindowsRadio.Size = new System.Drawing.Size(83, 20);
            this.WindowsRadio.TabIndex = 4;
            this.WindowsRadio.TabStop = true;
            this.WindowsRadio.Text = "Windows";
            this.WindowsRadio.UseVisualStyleBackColor = true;
            this.WindowsRadio.CheckedChanged += new System.EventHandler(this.WindowsRadio_CheckedChanged);
            // 
            // SqlRadio
            // 
            this.SqlRadio.AutoSize = true;
            this.SqlRadio.Location = new System.Drawing.Point(144, 190);
            this.SqlRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SqlRadio.Name = "SqlRadio";
            this.SqlRadio.Size = new System.Drawing.Size(91, 20);
            this.SqlRadio.TabIndex = 5;
            this.SqlRadio.TabStop = true;
            this.SqlRadio.Text = "Sql Server";
            this.SqlRadio.UseVisualStyleBackColor = true;
            this.SqlRadio.CheckedChanged += new System.EventHandler(this.SqlRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserName";
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(535, 16);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(133, 22);
            this.Username_txt.TabIndex = 8;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(535, 53);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(133, 22);
            this.Password_txt.TabIndex = 9;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // Path_txt
            // 
            this.Path_txt.Location = new System.Drawing.Point(103, 383);
            this.Path_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Path_txt.Name = "Path_txt";
            this.Path_txt.Size = new System.Drawing.Size(132, 22);
            this.Path_txt.TabIndex = 10;
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(264, 380);
            this.btn_sec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(100, 28);
            this.btn_sec.TabIndex = 11;
            this.btn_sec.Text = "...";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Path";
            // 
            // btn_yedekle
            // 
            this.btn_yedekle.Location = new System.Drawing.Point(103, 429);
            this.btn_yedekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_yedekle.Name = "btn_yedekle";
            this.btn_yedekle.Size = new System.Drawing.Size(100, 28);
            this.btn_yedekle.TabIndex = 13;
            this.btn_yedekle.Text = "Yedekle";
            this.btn_yedekle.UseVisualStyleBackColor = true;
            this.btn_yedekle.Click += new System.EventHandler(this.btn_yedekle_Click);
            // 
            // btnconnection
            // 
            this.btnconnection.Location = new System.Drawing.Point(390, 262);
            this.btnconnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(176, 30);
            this.btnconnection.TabIndex = 14;
            this.btnconnection.Text = "Test Connection";
            this.btnconnection.UseVisualStyleBackColor = true;
            this.btnconnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // rdatabase
            // 
            this.rdatabase.Location = new System.Drawing.Point(735, 317);
            this.rdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdatabase.Name = "rdatabase";
            this.rdatabase.Size = new System.Drawing.Size(132, 22);
            this.rdatabase.TabIndex = 18;
            // 
            // rserver
            // 
            this.rserver.Location = new System.Drawing.Point(735, 266);
            this.rserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rserver.Name = "rserver";
            this.rserver.Size = new System.Drawing.Size(132, 22);
            this.rserver.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Database";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Path";
            // 
            // rpath
            // 
            this.rpath.Location = new System.Drawing.Point(735, 370);
            this.rpath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpath.Name = "rpath";
            this.rpath.Size = new System.Drawing.Size(132, 22);
            this.rpath.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrestoresec
            // 
            this.btnrestoresec.Location = new System.Drawing.Point(917, 366);
            this.btnrestoresec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrestoresec.Name = "btnrestoresec";
            this.btnrestoresec.Size = new System.Drawing.Size(100, 28);
            this.btnrestoresec.TabIndex = 21;
            this.btnrestoresec.Text = "...";
            this.btnrestoresec.UseVisualStyleBackColor = true;
            this.btnrestoresec.Click += new System.EventHandler(this.btnrestoresec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RSql_radio
            // 
            this.RSql_radio.AutoSize = true;
            this.RSql_radio.Location = new System.Drawing.Point(947, 295);
            this.RSql_radio.Margin = new System.Windows.Forms.Padding(4);
            this.RSql_radio.Name = "RSql_radio";
            this.RSql_radio.Size = new System.Drawing.Size(91, 20);
            this.RSql_radio.TabIndex = 24;
            this.RSql_radio.TabStop = true;
            this.RSql_radio.Text = "Sql Server";
            this.RSql_radio.UseVisualStyleBackColor = true;
            this.RSql_radio.CheckedChanged += new System.EventHandler(this.RSql_radio_CheckedChanged);
            // 
            // Rwindows_radio
            // 
            this.Rwindows_radio.AutoSize = true;
            this.Rwindows_radio.Location = new System.Drawing.Point(947, 251);
            this.Rwindows_radio.Margin = new System.Windows.Forms.Padding(4);
            this.Rwindows_radio.Name = "Rwindows_radio";
            this.Rwindows_radio.Size = new System.Drawing.Size(83, 20);
            this.Rwindows_radio.TabIndex = 23;
            this.Rwindows_radio.TabStop = true;
            this.Rwindows_radio.Text = "Windows";
            this.Rwindows_radio.UseVisualStyleBackColor = true;
            this.Rwindows_radio.CheckedChanged += new System.EventHandler(this.Rwindows_radio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RSql_radio);
            this.Controls.Add(this.Rwindows_radio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrestoresec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rpath);
            this.Controls.Add(this.rdatabase);
            this.Controls.Add(this.rserver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnconnection);
            this.Controls.Add(this.btn_yedekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.Path_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SqlRadio);
            this.Controls.Add(this.WindowsRadio);
            this.Controls.Add(this.Database_txt);
            this.Controls.Add(this.Server_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Server_txt;
        private System.Windows.Forms.TextBox Database_txt;
        private System.Windows.Forms.RadioButton WindowsRadio;
        private System.Windows.Forms.RadioButton SqlRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Path_txt;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_yedekle;
        private System.Windows.Forms.Button btnconnection;
        private System.Windows.Forms.TextBox rdatabase;
        private System.Windows.Forms.TextBox rserver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrestoresec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton RSql_radio;
        private System.Windows.Forms.RadioButton Rwindows_radio;
    }
}

