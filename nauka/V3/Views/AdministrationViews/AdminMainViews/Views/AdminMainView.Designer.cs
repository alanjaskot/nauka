
namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Views
{
    partial class AdminMainView
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
            this.adminLeftPanelMenuuc1 = new nauka.V3.Views.AdministrationViews.UsereControls.AdminLeftPanelMenuUC();
            this.panelBottom.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonLogout.Text = "Wyloguj";
            // 
            // buttonOK
            // 
            this.buttonExit.Text = "Wyjście";
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.adminLeftPanelMenuuc1);
            // 
            // adminLeftPanelMenuuc1
            // 
            this.adminLeftPanelMenuuc1.Location = new System.Drawing.Point(0, 0);
            this.adminLeftPanelMenuuc1.Name = "adminLeftPanelMenuuc1";
            this.adminLeftPanelMenuuc1.Size = new System.Drawing.Size(300, 780);
            this.adminLeftPanelMenuuc1.TabIndex = 0;
            // 
            // AdminMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Name = "AdminMainView";
            this.Text = "AdminMainView";
            this.panelBottom.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal UsereControls.AdminLeftPanelMenuUC adminLeftPanelMenuuc1;
    }
}