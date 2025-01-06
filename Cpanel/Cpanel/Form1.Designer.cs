namespace Cpanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label name_userLabel;
            System.Windows.Forms.Label password_userLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name_userTextBox = new System.Windows.Forms.TextBox();
            this.password_userTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            name_userLabel = new System.Windows.Forms.Label();
            password_userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(154, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(273, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_userLabel
            // 
            name_userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            name_userLabel.AutoSize = true;
            name_userLabel.Location = new System.Drawing.Point(112, 229);
            name_userLabel.Name = "name_userLabel";
            name_userLabel.Size = new System.Drawing.Size(55, 13);
            name_userLabel.TabIndex = 7;
            name_userLabel.Text = "Username";
            // 
            // name_userTextBox
            // 
            this.name_userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name_user", true));
            this.name_userTextBox.Location = new System.Drawing.Point(196, 226);
            this.name_userTextBox.Name = "name_userTextBox";
            this.name_userTextBox.Size = new System.Drawing.Size(195, 20);
            this.name_userTextBox.TabIndex = 8;
            // 
            // password_userLabel
            // 
            password_userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            password_userLabel.AutoSize = true;
            password_userLabel.Location = new System.Drawing.Point(112, 255);
            password_userLabel.Name = "password_userLabel";
            password_userLabel.Size = new System.Drawing.Size(53, 13);
            password_userLabel.TabIndex = 9;
            password_userLabel.Text = "Password";
            // 
            // password_userTextBox
            // 
            this.password_userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password_user", true));
            this.password_userTextBox.Location = new System.Drawing.Point(196, 252);
            this.password_userTextBox.Name = "password_userTextBox";
            this.password_userTextBox.Size = new System.Drawing.Size(195, 20);
            this.password_userTextBox.TabIndex = 10;
            this.password_userTextBox.UseSystemPasswordChar = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Cpanel.users);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(name_userLabel);
            this.Controls.Add(this.name_userTextBox);
            this.Controls.Add(password_userLabel);
            this.Controls.Add(this.password_userTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TextBox name_userTextBox;
        private System.Windows.Forms.TextBox password_userTextBox;
    }
}

