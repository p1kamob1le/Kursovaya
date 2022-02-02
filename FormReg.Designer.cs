namespace WindowsFormsApp1
{
    partial class FormReg
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUserpass = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCan = new System.Windows.Forms.Button();
            this.labelauth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(31, 31);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(189, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxUserpass
            // 
            this.textBoxUserpass.Location = new System.Drawing.Point(31, 57);
            this.textBoxUserpass.Name = "textBoxUserpass";
            this.textBoxUserpass.PasswordChar = '*';
            this.textBoxUserpass.Size = new System.Drawing.Size(189, 20);
            this.textBoxUserpass.TabIndex = 1;
            this.textBoxUserpass.TextChanged += new System.EventHandler(this.textBoxUserpass_TextChanged);
            this.textBoxUserpass.Enter += new System.EventHandler(this.textBoxUserpass_Enter);
            this.textBoxUserpass.Leave += new System.EventHandler(this.textBoxUserpass_Leave);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(31, 96);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(129, 23);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCan
            // 
            this.buttonCan.Location = new System.Drawing.Point(166, 96);
            this.buttonCan.Name = "buttonCan";
            this.buttonCan.Size = new System.Drawing.Size(54, 23);
            this.buttonCan.TabIndex = 3;
            this.buttonCan.Text = "Отмена";
            this.buttonCan.UseVisualStyleBackColor = true;
            this.buttonCan.Click += new System.EventHandler(this.buttonCan_Click);
            // 
            // labelauth
            // 
            this.labelauth.AutoSize = true;
            this.labelauth.Location = new System.Drawing.Point(87, 127);
            this.labelauth.Name = "labelauth";
            this.labelauth.Size = new System.Drawing.Size(73, 13);
            this.labelauth.TabIndex = 4;
            this.labelauth.Text = "Авторизация";
            this.labelauth.Click += new System.EventHandler(this.labelauth_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 149);
            this.Controls.Add(this.labelauth);
            this.Controls.Add(this.buttonCan);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxUserpass);
            this.Controls.Add(this.textBoxUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUserpass;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCan;
        private System.Windows.Forms.Label labelauth;
    }
}