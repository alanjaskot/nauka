
namespace nauka.V3.Views.AdministrationsViewsViews.AdministrationVacationViews
{
    partial class AdministrationVacationView
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
            this.administrationVacationUserControl1 = new nauka.V3.Views.AdministrationsViewsViews.AdministrationVacationViews.UserController.AdministrationVacationUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 646);
            this.panelBottom.Size = new System.Drawing.Size(1436, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 496);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.administrationVacationUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1136, 496);
            // 
            // administrationVacationUserControl1
            // 
            this.administrationVacationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.administrationVacationUserControl1.Name = "administrationVacationUserControl1";
            this.administrationVacationUserControl1.Size = new System.Drawing.Size(1136, 496);
            this.administrationVacationUserControl1.TabIndex = 0;
            // 
            // AdministrationVacationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 740);
            this.Name = "AdministrationVacationView";
            this.Text = "AdministrationVacationView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserController.AdministrationVacationUserControl administrationVacationUserControl1;
    }
}