
namespace nauka.V3.Views.AdministrationsViewsViews.MenagePermissonViews.UserController
{
    partial class MenagePermissonUserControl
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
            this.labelShowPermisson = new System.Windows.Forms.Label();
            this.checkBoxVacationPermisoon = new System.Windows.Forms.CheckBox();
            this.checkBoxEmployeeePermisson = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShowPermisson
            // 
            this.labelShowPermisson.AutoSize = true;
            this.labelShowPermisson.Location = new System.Drawing.Point(37, 49);
            this.labelShowPermisson.Name = "labelShowPermisson";
            this.labelShowPermisson.Size = new System.Drawing.Size(177, 25);
            this.labelShowPermisson.TabIndex = 0;
            this.labelShowPermisson.Text = "Możliwe uprawnienia";
            // 
            // checkBoxVacationPermisoon
            // 
            this.checkBoxVacationPermisoon.AutoSize = true;
            this.checkBoxVacationPermisoon.Location = new System.Drawing.Point(37, 187);
            this.checkBoxVacationPermisoon.Name = "checkBoxVacationPermisoon";
            this.checkBoxVacationPermisoon.Size = new System.Drawing.Size(109, 29);
            this.checkBoxVacationPermisoon.TabIndex = 1;
            this.checkBoxVacationPermisoon.Text = "  wakacje";
            this.checkBoxVacationPermisoon.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployeeePermisson
            // 
            this.checkBoxEmployeeePermisson.AutoSize = true;
            this.checkBoxEmployeeePermisson.Location = new System.Drawing.Point(37, 247);
            this.checkBoxEmployeeePermisson.Name = "checkBoxEmployeeePermisson";
            this.checkBoxEmployeeePermisson.Size = new System.Drawing.Size(137, 29);
            this.checkBoxEmployeeePermisson.TabIndex = 2;
            this.checkBoxEmployeeePermisson.Text = "  pracownicy";
            this.checkBoxEmployeeePermisson.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "imie";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(37, 130);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(87, 25);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(156, 91);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(0, 25);
            this.labelEmployeeName.TabIndex = 5;
            // 
            // labelEmployeeSurname
            // 
            this.labelEmployeeSurname.AutoSize = true;
            this.labelEmployeeSurname.Location = new System.Drawing.Point(156, 130);
            this.labelEmployeeSurname.Name = "labelEmployeeSurname";
            this.labelEmployeeSurname.Size = new System.Drawing.Size(0, 25);
            this.labelEmployeeSurname.TabIndex = 6;
            // 
            // MenagePermissonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEmployeeSurname);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxEmployeeePermisson);
            this.Controls.Add(this.checkBoxVacationPermisoon);
            this.Controls.Add(this.labelShowPermisson);
            this.Name = "MenagePermissonUserControl";
            this.Size = new System.Drawing.Size(296, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShowPermisson;
        protected internal System.Windows.Forms.CheckBox checkBoxVacationPermisoon;
        protected internal System.Windows.Forms.CheckBox checkBoxEmployeeePermisson;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        protected internal System.Windows.Forms.Label labelEmployeeName;
        protected internal System.Windows.Forms.Label labelEmployeeSurname;
    }
}
