
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class AdminLeftPanelMenuUC
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
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonVacations = new System.Windows.Forms.Button();
            this.buttonVacationApplications = new System.Windows.Forms.Button();
            this.buttonPermission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSection
            // 
            this.buttonSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSection.Location = new System.Drawing.Point(56, 84);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(189, 56);
            this.buttonSection.TabIndex = 1;
            this.buttonSection.Text = "Działy";
            this.buttonSection.UseVisualStyleBackColor = true;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployees.Location = new System.Drawing.Point(56, 198);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(189, 56);
            this.buttonEmployees.TabIndex = 2;
            this.buttonEmployees.Text = "Pracownicy";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonVacations
            // 
            this.buttonVacations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVacations.Location = new System.Drawing.Point(56, 312);
            this.buttonVacations.Name = "buttonVacations";
            this.buttonVacations.Size = new System.Drawing.Size(189, 56);
            this.buttonVacations.TabIndex = 3;
            this.buttonVacations.Text = "Absencje";
            this.buttonVacations.UseVisualStyleBackColor = true;
            // 
            // buttonVacationApplications
            // 
            this.buttonVacationApplications.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVacationApplications.Location = new System.Drawing.Point(56, 444);
            this.buttonVacationApplications.Name = "buttonVacationApplications";
            this.buttonVacationApplications.Size = new System.Drawing.Size(189, 56);
            this.buttonVacationApplications.TabIndex = 4;
            this.buttonVacationApplications.Text = "Wnioski o urlop";
            this.buttonVacationApplications.UseVisualStyleBackColor = true;
            // 
            // buttonPermission
            // 
            this.buttonPermission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPermission.Location = new System.Drawing.Point(56, 562);
            this.buttonPermission.Name = "buttonPermission";
            this.buttonPermission.Size = new System.Drawing.Size(189, 56);
            this.buttonPermission.TabIndex = 5;
            this.buttonPermission.Text = "Uprawnienia";
            this.buttonPermission.UseVisualStyleBackColor = true;
            // 
            // AdminLeftPanelMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPermission);
            this.Controls.Add(this.buttonVacationApplications);
            this.Controls.Add(this.buttonVacations);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonSection);
            this.Name = "AdminLeftPanelMenuUC";
            this.Size = new System.Drawing.Size(300, 780);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Button buttonSection;
        protected internal System.Windows.Forms.Button buttonEmployees;
        protected internal System.Windows.Forms.Button buttonVacations;
        protected internal System.Windows.Forms.Button buttonVacationApplications;
        protected internal System.Windows.Forms.Button buttonPermission;
    }
}
