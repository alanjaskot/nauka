
namespace nauka.V3.Views.UserControllers
{
    partial class SingleEmployeeUserControl
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameEmployee = new System.Windows.Forms.Label();
            this.labelSurnameEmployee = new System.Windows.Forms.Label();
            this.labelUsernameEmployee = new System.Windows.Forms.Label();
            this.labelEmailEmployee = new System.Windows.Forms.Label();
            this.labelSexEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(73, 248);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "E-mail";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(73, 315);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(45, 25);
            this.labelSex.TabIndex = 16;
            this.labelSex.Text = "płeć";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(73, 185);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(101, 25);
            this.labelUser.TabIndex = 14;
            this.labelUser.Text = "użytkownik";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(73, 127);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(84, 25);
            this.labelSurname.TabIndex = 13;
            this.labelSurname.Text = "nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(73, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 25);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "imie";
            // 
            // labelNameEmployee
            // 
            this.labelNameEmployee.AutoSize = true;
            this.labelNameEmployee.Location = new System.Drawing.Point(235, 73);
            this.labelNameEmployee.Name = "labelNameEmployee";
            this.labelNameEmployee.Size = new System.Drawing.Size(0, 25);
            this.labelNameEmployee.TabIndex = 18;
            // 
            // labelSurnameEmployee
            // 
            this.labelSurnameEmployee.AutoSize = true;
            this.labelSurnameEmployee.Location = new System.Drawing.Point(235, 127);
            this.labelSurnameEmployee.Name = "labelSurnameEmployee";
            this.labelSurnameEmployee.Size = new System.Drawing.Size(0, 25);
            this.labelSurnameEmployee.TabIndex = 19;
            // 
            // labelUsernameEmployee
            // 
            this.labelUsernameEmployee.AutoSize = true;
            this.labelUsernameEmployee.Location = new System.Drawing.Point(235, 185);
            this.labelUsernameEmployee.Name = "labelUsernameEmployee";
            this.labelUsernameEmployee.Size = new System.Drawing.Size(0, 25);
            this.labelUsernameEmployee.TabIndex = 20;
            // 
            // labelEmailEmployee
            // 
            this.labelEmailEmployee.AutoSize = true;
            this.labelEmailEmployee.Location = new System.Drawing.Point(235, 248);
            this.labelEmailEmployee.Name = "labelEmailEmployee";
            this.labelEmailEmployee.Size = new System.Drawing.Size(0, 25);
            this.labelEmailEmployee.TabIndex = 21;
            // 
            // labelSexEmployee
            // 
            this.labelSexEmployee.AutoSize = true;
            this.labelSexEmployee.Location = new System.Drawing.Point(235, 315);
            this.labelSexEmployee.Name = "labelSexEmployee";
            this.labelSexEmployee.Size = new System.Drawing.Size(0, 25);
            this.labelSexEmployee.TabIndex = 22;
            // 
            // SingleEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSexEmployee);
            this.Controls.Add(this.labelEmailEmployee);
            this.Controls.Add(this.labelUsernameEmployee);
            this.Controls.Add(this.labelSurnameEmployee);
            this.Controls.Add(this.labelNameEmployee);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "SingleEmployeeUserControl";
            this.Size = new System.Drawing.Size(549, 664);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.Label labelNameEmployee;
        protected internal System.Windows.Forms.Label labelSurnameEmployee;
        protected internal System.Windows.Forms.Label labelUsernameEmployee;
        protected internal System.Windows.Forms.Label labelEmailEmployee;
        protected internal System.Windows.Forms.Label labelSexEmployee;
    }
}
