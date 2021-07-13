
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
            this.userLeftPanelMenuuc1 = new nauka.V3.Views.UserViews.UserControls.UserLeftPanelMenuUC();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Text = "Wyloguj";
            // 
            // buttonExit
            // 
            this.buttonExit.Text = "Wyjście";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.userLeftPanelMenuuc1);
            this.panelTop.Controls.SetChildIndex(this.userLeftPanelMenuuc1, 0);
            // 
            // userLeftPanelMenuuc1
            // 
            this.userLeftPanelMenuuc1.Location = new System.Drawing.Point(0, 0);
            this.userLeftPanelMenuuc1.Name = "userLeftPanelMenuuc1";
            this.userLeftPanelMenuuc1.Size = new System.Drawing.Size(1898, 150);
            this.userLeftPanelMenuuc1.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        protected internal UserViews.UserControls.UserLeftPanelMenuUC userLeftPanelMenuuc1;
    }
}