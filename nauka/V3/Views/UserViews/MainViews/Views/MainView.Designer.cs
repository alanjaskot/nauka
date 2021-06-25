
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
            this.panelLeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Text = "Wyloguj";
            // 
            // buttonOK
            // 
            this.buttonOK.Text = "Wyjście";
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.userLeftPanelMenuuc1);
            // 
            // userLeftPanelMenuuc1
            // 
            this.userLeftPanelMenuuc1.Location = new System.Drawing.Point(0, 0);
            this.userLeftPanelMenuuc1.Name = "userLeftPanelMenuuc1";
            this.userLeftPanelMenuuc1.Size = new System.Drawing.Size(300, 780);
            this.userLeftPanelMenuuc1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelBottom.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        protected internal UserViews.UserControls.UserLeftPanelMenuUC userLeftPanelMenuuc1;
    }
}