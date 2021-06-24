
using nauka.V3.BaseViews;

namespace nauka.V3.LoginViews
{
    partial class LoginView: baseView
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
            this.loginMainUserControl11 = new nauka.V3.Views.UserControllers.LoginMainUserControl1();
            this.leftPanelUserControl2 = new nauka.V3.Views.UserControllers.LeftPanelUserControl();
            this.panelBottom.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 679);
            this.panelBottom.Size = new System.Drawing.Size(1490, 65);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1199, 19);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1338, 19);
            this.buttonOK.Text = "Logowanie";
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.leftPanelUserControl2);
            this.panelLeftMenu.Size = new System.Drawing.Size(310, 529);
            this.panelLeftMenu.Controls.SetChildIndex(this.leftPanelUserControl2, 0);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.loginMainUserControl11);
            this.panelMain.Location = new System.Drawing.Point(310, 150);
            this.panelMain.Size = new System.Drawing.Size(1180, 529);
            // 
            // loginMainUserControl11
            // 
            this.loginMainUserControl11.Location = new System.Drawing.Point(0, 0);
            this.loginMainUserControl11.Name = "loginMainUserControl11";
            this.loginMainUserControl11.Size = new System.Drawing.Size(1180, 529);
            this.loginMainUserControl11.TabIndex = 0;
            // 
            // leftPanelUserControl2
            // 
            this.leftPanelUserControl2.Location = new System.Drawing.Point(0, 0);
            this.leftPanelUserControl2.Name = "leftPanelUserControl2";
            this.leftPanelUserControl2.Size = new System.Drawing.Size(310, 529);
            this.leftPanelUserControl2.TabIndex = 1;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 744);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.panelBottom.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControllers.LoginMainUserControl1 loginMainUserControl11;
        private Views.UserControllers.LeftPanelUserControl leftPanelUserControl2;
    }
}