
namespace nauka.V3.Views.UserControllers
{
    partial class LeftPanelUserControl
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
            this.buttonSection = new System.Windows.Forms.Button();
            this.buttonVacation = new System.Windows.Forms.Button();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.buttonVaccationApplication = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSection
            // 
            this.buttonSection.Location = new System.Drawing.Point(35, 125);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(237, 34);
            this.buttonSection.TabIndex = 2;
            this.buttonSection.Text = "Wydziały";
            this.buttonSection.UseVisualStyleBackColor = true;
            // 
            // buttonVacation
            // 
            this.buttonVacation.Location = new System.Drawing.Point(35, 355);
            this.buttonVacation.Name = "buttonVacation";
            this.buttonVacation.Size = new System.Drawing.Size(237, 34);
            this.buttonVacation.TabIndex = 5;
            this.buttonVacation.Text = "Urlopy";
            this.buttonVacation.UseVisualStyleBackColor = true;
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.Location = new System.Drawing.Point(35, 47);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(237, 34);
            this.buttonDashBoard.TabIndex = 7;
            this.buttonDashBoard.Text = "Tablica";
            this.buttonDashBoard.UseVisualStyleBackColor = true;
            // 
            // buttonVaccationApplication
            // 
            this.buttonVaccationApplication.Location = new System.Drawing.Point(35, 277);
            this.buttonVaccationApplication.Name = "buttonVaccationApplication";
            this.buttonVaccationApplication.Size = new System.Drawing.Size(237, 34);
            this.buttonVaccationApplication.TabIndex = 8;
            this.buttonVaccationApplication.Text = "Wnioski";
            this.buttonVaccationApplication.UseVisualStyleBackColor = true;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(35, 202);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(237, 34);
            this.buttonEmployee.TabIndex = 9;
            this.buttonEmployee.Text = "Pracownicy";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(35, 426);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(237, 34);
            this.buttonAdmin.TabIndex = 10;
            this.buttonAdmin.Text = "Administracja";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // LeftPanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonVaccationApplication);
            this.Controls.Add(this.buttonDashBoard);
            this.Controls.Add(this.buttonVacation);
            this.Controls.Add(this.buttonSection);
            this.Name = "LeftPanelUserControl";
            this.Size = new System.Drawing.Size(307, 840);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonSection;
        private System.Windows.Forms.Button buttonVacation;
        protected internal System.Windows.Forms.Button buttonDashBoard;
        protected internal System.Windows.Forms.Button buttonVaccationApplication;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonAdmin;
    }
}
