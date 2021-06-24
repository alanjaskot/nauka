
namespace nauka.V3.Views.VacationViews
{
    partial class VacationViews
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
            this.vacationDisplayUserControl1 = new nauka.V3.Views.UserControllers.VacationDisplayUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 712);
            this.panelBottom.Size = new System.Drawing.Size(1609, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 562);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.vacationDisplayUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1309, 562);
            // 
            // vacationDisplayUserControl1
            // 
            this.vacationDisplayUserControl1.Location = new System.Drawing.Point(0, 0);
            this.vacationDisplayUserControl1.Name = "vacationDisplayUserControl1";
            this.vacationDisplayUserControl1.Size = new System.Drawing.Size(1271, 559);
            this.vacationDisplayUserControl1.TabIndex = 0;
            // 
            // VacationViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 806);
            this.Name = "VacationViews";
            this.Text = "VacationViews";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.VacationDisplayUserControl vacationDisplayUserControl1;
    }
}