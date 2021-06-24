
namespace nauka.V3.Views.MenageVacationApplicationViews
{
    partial class MenageVacationApplicationView
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
            this.menageAdmnistrtationVacationApplicationUserControl1 = new nauka.V3.Views.AdministrationsViewsViews.AdministrationVacationViews.UserController.MenageAdmnistrtationVacationApplicationUserControl();
            this.menageVacationApplicatoinUserControl1 = new nauka.V3.Views.UserControllers.MenageVacationApplicatoinUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 642);
            this.panelBottom.Size = new System.Drawing.Size(1465, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 492);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.menageVacationApplicatoinUserControl1);
            this.panelMain.Controls.Add(this.menageAdmnistrtationVacationApplicationUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1165, 492);
            // 
            // menageAdmnistrtationVacationApplicationUserControl1
            // 
            this.menageAdmnistrtationVacationApplicationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.menageAdmnistrtationVacationApplicationUserControl1.Name = "menageAdmnistrtationVacationApplicationUserControl1";
            this.menageAdmnistrtationVacationApplicationUserControl1.Size = new System.Drawing.Size(659, 492);
            this.menageAdmnistrtationVacationApplicationUserControl1.TabIndex = 0;
            // 
            // menageVacationApplicatoinUserControl1
            // 
            this.menageVacationApplicatoinUserControl1.Location = new System.Drawing.Point(46, 0);
            this.menageVacationApplicatoinUserControl1.Name = "menageVacationApplicatoinUserControl1";
            this.menageVacationApplicatoinUserControl1.Size = new System.Drawing.Size(509, 453);
            this.menageVacationApplicatoinUserControl1.TabIndex = 1;
            // 
            // MenageVacationApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 736);
            this.Name = "MenageVacationApplicationView";
            this.Text = "MenageVacationApplicationView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AdministrationsViewsViews.AdministrationVacationViews.UserController.MenageAdmnistrtationVacationApplicationUserControl menageAdmnistrtationVacationApplicationUserControl1;
        private UserControllers.MenageVacationApplicatoinUserControl menageVacationApplicatoinUserControl1;
    }
}