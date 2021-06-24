
namespace nauka.V3.Views.AdministrationsViewsViews.UserControllers
{
    partial class PermittedUserControl
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
            this.buttonEmployeeMenage = new System.Windows.Forms.Button();
            this.buttonVacationManege = new System.Windows.Forms.Button();
            this.buttonPermisson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmployeeMenage
            // 
            this.buttonEmployeeMenage.Location = new System.Drawing.Point(51, 62);
            this.buttonEmployeeMenage.Name = "buttonEmployeeMenage";
            this.buttonEmployeeMenage.Size = new System.Drawing.Size(112, 34);
            this.buttonEmployeeMenage.TabIndex = 0;
            this.buttonEmployeeMenage.Text = "Pracownicy";
            this.buttonEmployeeMenage.UseVisualStyleBackColor = true;
            // 
            // buttonVacationManege
            // 
            this.buttonVacationManege.Location = new System.Drawing.Point(525, 62);
            this.buttonVacationManege.Name = "buttonVacationManege";
            this.buttonVacationManege.Size = new System.Drawing.Size(112, 34);
            this.buttonVacationManege.TabIndex = 1;
            this.buttonVacationManege.Text = "Urlopy";
            this.buttonVacationManege.UseVisualStyleBackColor = true;
            // 
            // buttonPermisson
            // 
            this.buttonPermisson.Location = new System.Drawing.Point(282, 62);
            this.buttonPermisson.Name = "buttonPermisson";
            this.buttonPermisson.Size = new System.Drawing.Size(145, 34);
            this.buttonPermisson.TabIndex = 2;
            this.buttonPermisson.Text = "Uprawnienia";
            this.buttonPermisson.UseVisualStyleBackColor = true;
            // 
            // PermittedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPermisson);
            this.Controls.Add(this.buttonVacationManege);
            this.Controls.Add(this.buttonEmployeeMenage);
            this.Name = "PermittedUserControl";
            this.Size = new System.Drawing.Size(699, 163);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonEmployeeMenage;
        protected internal System.Windows.Forms.Button buttonPermisson;
        protected internal System.Windows.Forms.Button buttonVacationManege;
    }
}
