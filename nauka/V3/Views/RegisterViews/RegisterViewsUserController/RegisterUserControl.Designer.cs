
namespace nauka.V3.Views.UserControllers
{
    partial class RegisterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "imie";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(42, 98);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(84, 25);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "nazwisko";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(42, 156);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 25);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "użytkownik";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(42, 211);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(55, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "hasło";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 314);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-mail";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(42, 361);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(44, 25);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "Płeć";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(192, 98);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(238, 31);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(192, 156);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(238, 31);
            this.textBoxUser.TabIndex = 8;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(42, 263);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(126, 25);
            this.labelConfirmPassword.TabIndex = 9;
            this.labelConfirmPassword.Text = "powtórz hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(192, 208);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(238, 31);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(192, 263);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(238, 31);
            this.textBoxPasswordConfirm.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(192, 311);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(238, 31);
            this.textBoxEmail.TabIndex = 12;
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.Location = new System.Drawing.Point(192, 361);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(97, 29);
            this.radioButtonWomen.TabIndex = 13;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "Kobieta";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(192, 414);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(122, 29);
            this.radioButtonMan.TabIndex = 14;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Mężczyzna";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // RegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.radioButtonWomen);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(710, 777);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        protected internal System.Windows.Forms.RadioButton radioButtonWomen;
        protected internal System.Windows.Forms.RadioButton radioButtonMan;
        protected internal System.Windows.Forms.TextBox textBoxPasswordConfirm;
        protected internal System.Windows.Forms.TextBox textBoxPassword;
        protected internal System.Windows.Forms.TextBox textBoxUser;
        protected internal System.Windows.Forms.TextBox textBoxSurname;
        protected internal System.Windows.Forms.TextBox textBoxName;
    }
}
