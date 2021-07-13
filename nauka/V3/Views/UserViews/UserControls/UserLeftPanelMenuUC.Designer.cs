
namespace nauka.V3.Views.UserViews.UserControls
{
    partial class UserLeftPanelMenuUC
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
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonVacations = new System.Windows.Forms.Button();
            this.buttonVacationApplications = new System.Windows.Forms.Button();
            this.buttonAdministration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.Location = new System.Drawing.Point(67, 51);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(300, 50);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Kalendarz";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployee.Location = new System.Drawing.Point(438, 51);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(300, 50);
            this.buttonEmployee.TabIndex = 1;
            this.buttonEmployee.Text = "Pracownik";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonVacations
            // 
            this.buttonVacations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVacations.Location = new System.Drawing.Point(819, 51);
            this.buttonVacations.Name = "buttonVacations";
            this.buttonVacations.Size = new System.Drawing.Size(300, 50);
            this.buttonVacations.TabIndex = 2;
            this.buttonVacations.Text = "Urlopy";
            this.buttonVacations.UseVisualStyleBackColor = true;
            // 
            // buttonVacationApplications
            // 
            this.buttonVacationApplications.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVacationApplications.Location = new System.Drawing.Point(1194, 51);
            this.buttonVacationApplications.Name = "buttonVacationApplications";
            this.buttonVacationApplications.Size = new System.Drawing.Size(300, 50);
            this.buttonVacationApplications.TabIndex = 3;
            this.buttonVacationApplications.Text = "Wnioski o urlop";
            this.buttonVacationApplications.UseVisualStyleBackColor = true;
            // 
            // buttonAdministration
            // 
            this.buttonAdministration.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdministration.Location = new System.Drawing.Point(1549, 51);
            this.buttonAdministration.Name = "buttonAdministration";
            this.buttonAdministration.Size = new System.Drawing.Size(300, 50);
            this.buttonAdministration.TabIndex = 4;
            this.buttonAdministration.Text = "Panel Administratora";
            this.buttonAdministration.UseVisualStyleBackColor = true;
            // 
            // UserLeftPanelMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdministration);
            this.Controls.Add(this.buttonVacationApplications);
            this.Controls.Add(this.buttonVacations);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonDashboard);
            this.Name = "UserLeftPanelMenuUC";
            this.Size = new System.Drawing.Size(1898, 150);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonDashboard;
        protected internal System.Windows.Forms.Button buttonEmployee;
        protected internal System.Windows.Forms.Button buttonVacations;
        protected internal System.Windows.Forms.Button buttonVacationApplications;
        protected internal System.Windows.Forms.Button buttonAdministration;
    }
}
