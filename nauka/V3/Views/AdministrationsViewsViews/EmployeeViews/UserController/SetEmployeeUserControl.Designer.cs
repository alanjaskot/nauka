
namespace nauka.V3.Views.UserControllers
{
    partial class SetEmployeeUserControl
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "imie";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(234, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(21, 81);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(84, 25);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "nazwisko";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(140, 78);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(234, 31);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(21, 139);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(101, 25);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "użytkownik";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(140, 136);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(234, 31);
            this.textBoxUser.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(21, 205);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(55, 25);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(140, 202);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(234, 31);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(21, 336);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(45, 25);
            this.labelSex.TabIndex = 8;
            this.labelSex.Text = "płeć";
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.Location = new System.Drawing.Point(140, 332);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(96, 29);
            this.radioButtonWomen.TabIndex = 9;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "kobieta";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(140, 368);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(122, 29);
            this.radioButtonMan.TabIndex = 10;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "mężczyzna";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 269);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(140, 269);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(234, 31);
            this.textBoxEmail.TabIndex = 12;
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.radioButtonWomen);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(398, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        protected internal System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelUser;
        protected internal System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPassword;
        protected internal System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.Label labelEmail;
        protected internal System.Windows.Forms.TextBox textBoxEmail;
    }
}
