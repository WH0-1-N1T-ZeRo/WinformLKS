namespace Cpanel
{
    partial class Form4
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
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label name_userLabel;
            System.Windows.Forms.Label password_userLabel;
            System.Windows.Forms.Label rolesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.name_userTextBox = new System.Windows.Forms.TextBox();
            this.password_userTextBox = new System.Windows.Forms.TextBox();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.RolebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            birthdateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            name_userLabel = new System.Windows.Forms.Label();
            password_userLabel = new System.Windows.Forms.Label();
            rolesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolebindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdateLabel
            // 
            birthdateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(56, 116);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(49, 13);
            birthdateLabel.TabIndex = 1;
            birthdateLabel.Text = "Birthdate";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(55, 89);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Addres";
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(55, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "UserID";
            // 
            // name_userLabel
            // 
            name_userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            name_userLabel.AutoSize = true;
            name_userLabel.Location = new System.Drawing.Point(55, 63);
            name_userLabel.Name = "name_userLabel";
            name_userLabel.Size = new System.Drawing.Size(35, 13);
            name_userLabel.TabIndex = 7;
            name_userLabel.Text = "Name";
            // 
            // password_userLabel
            // 
            password_userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            password_userLabel.AutoSize = true;
            password_userLabel.Location = new System.Drawing.Point(55, 168);
            password_userLabel.Name = "password_userLabel";
            password_userLabel.Size = new System.Drawing.Size(53, 13);
            password_userLabel.TabIndex = 9;
            password_userLabel.Text = "Password";
            // 
            // rolesLabel
            // 
            rolesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            rolesLabel.AutoSize = true;
            rolesLabel.Location = new System.Drawing.Point(57, 141);
            rolesLabel.Name = "rolesLabel";
            rolesLabel.Size = new System.Drawing.Size(34, 13);
            rolesLabel.TabIndex = 10;
            rolesLabel.Text = "Roles";
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(139, 112);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Cpanel.users);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(139, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(139, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // name_userTextBox
            // 
            this.name_userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name_user", true));
            this.name_userTextBox.Location = new System.Drawing.Point(139, 60);
            this.name_userTextBox.Name = "name_userTextBox";
            this.name_userTextBox.Size = new System.Drawing.Size(200, 20);
            this.name_userTextBox.TabIndex = 8;
            // 
            // password_userTextBox
            // 
            this.password_userTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password_user", true));
            this.password_userTextBox.Location = new System.Drawing.Point(139, 165);
            this.password_userTextBox.Name = "password_userTextBox";
            this.password_userTextBox.Size = new System.Drawing.Size(200, 20);
            this.password_userTextBox.TabIndex = 10;
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rolesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "roles_id", true));
            this.rolesComboBox.DataSource = this.RolebindingSource;
            this.rolesComboBox.DisplayMember = "title";
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(139, 138);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(200, 21);
            this.rolesComboBox.TabIndex = 11;
            this.rolesComboBox.ValueMember = "id";
            // 
            // RolebindingSource
            // 
            this.RolebindingSource.DataSource = typeof(Cpanel.roles);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(60, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(264, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(rolesLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(name_userLabel);
            this.Controls.Add(this.name_userTextBox);
            this.Controls.Add(password_userLabel);
            this.Controls.Add(this.password_userTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolebindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox name_userTextBox;
        private System.Windows.Forms.TextBox password_userTextBox;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource RolebindingSource;
    }
}