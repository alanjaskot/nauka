
namespace nauka.V3.Views.SectionViews
{
    partial class SectionView
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
            this.sectionUserControl1 = new nauka.V3.Views.SectionUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 633);
            this.panelBottom.Size = new System.Drawing.Size(1453, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 483);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.sectionUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1153, 483);
            // 
            // sectionUserControl1
            // 
            this.sectionUserControl1.Location = new System.Drawing.Point(0, 0);
            this.sectionUserControl1.Name = "sectionUserControl1";
            this.sectionUserControl1.Size = new System.Drawing.Size(900, 483);
            this.sectionUserControl1.TabIndex = 0;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 727);
            this.Name = "SectionView";
            this.Text = "SectionView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SectionUserControl sectionUserControl1;
    }
}