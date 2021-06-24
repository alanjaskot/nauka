
namespace nauka.V3.Views.MenageVacationApplicationViews
{
    partial class MenageVacationApplication
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
            this.menageVacationApplicatoinUserControl1 = new nauka.V3.Views.UserControllers.MenageVacationApplicatoinUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 652);
            this.panelBottom.Size = new System.Drawing.Size(1518, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 502);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.menageVacationApplicatoinUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1218, 502);
            this.panelMain.Controls.SetChildIndex(this.menageVacationApplicatoinUserControl1, 0);
            // 
            // menageVacationApplicatoinUserControl1
            // 
            this.menageVacationApplicatoinUserControl1.Location = new System.Drawing.Point(650, 0);
            this.menageVacationApplicatoinUserControl1.Name = "menageVacationApplicatoinUserControl1";
            this.menageVacationApplicatoinUserControl1.Size = new System.Drawing.Size(568, 502);
            this.menageVacationApplicatoinUserControl1.TabIndex = 1;
            // 
            // MenageVacationApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 746);
            this.Name = "MenageVacationApplication";
            this.Text = "MenageVacationApplication";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.MenageVacationApplicatoinUserControl menageVacationApplicatoinUserControl1;
    }
}