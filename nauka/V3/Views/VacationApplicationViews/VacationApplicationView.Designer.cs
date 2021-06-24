
namespace nauka.V3.Views.VacationApplicationViews
{
    partial class VacationApplicationView
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
            this.listVacationApplicationUserControl1 = new nauka.V3.Views.UserControllers.ListVacationApplicationUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 650);
            this.panelBottom.Size = new System.Drawing.Size(1496, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 500);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.listVacationApplicationUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1196, 500);
            // 
            // listVacationApplicationUserControl1
            // 
            this.listVacationApplicationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.listVacationApplicationUserControl1.Name = "listVacationApplicationUserControl1";
            this.listVacationApplicationUserControl1.Size = new System.Drawing.Size(607, 500);
            this.listVacationApplicationUserControl1.TabIndex = 0;
            // 
            // VacationApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 744);
            this.Name = "VacationApplicationView";
            this.Text = "VacationApplicationView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.ListVacationApplicationUserControl listVacationApplicationUserControl1;
    }
}