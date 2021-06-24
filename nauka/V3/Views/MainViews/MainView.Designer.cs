
namespace nauka.V3.Views.MianViews
{
    partial class MainView
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
            this.mainPanelUserControl1 = new nauka.V3.Views.UserControllers.MainPanelUserControl();
            this.panelBottom.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 751);
            this.panelBottom.Size = new System.Drawing.Size(1656, 94);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.mainPanelUserControl1);
            this.panelMain.Location = new System.Drawing.Point(355, 150);
            this.panelMain.Size = new System.Drawing.Size(1301, 601);
            // 
            // mainPanelUserControl1
            // 
            this.mainPanelUserControl1.Location = new System.Drawing.Point(28, 35);
            this.mainPanelUserControl1.Name = "mainPanelUserControl1";
            this.mainPanelUserControl1.Size = new System.Drawing.Size(1252, 525);
            this.mainPanelUserControl1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 845);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelBottom.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private UserControllers.MainPanelUserControl mainPanelUserControl1;
    }
}