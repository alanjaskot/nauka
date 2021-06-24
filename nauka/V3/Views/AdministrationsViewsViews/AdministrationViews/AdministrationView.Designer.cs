
namespace nauka.V3.Views.AdministrationsViewsViews.AdministrationViews
{
    partial class AdministrationView
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
            this.noPermissionUserControl1 = new nauka.V3.Views.AdministrationsViewsViews.UserControllers.NoPermissionUserControl();
            this.permittedUserControl1 = new nauka.V3.Views.AdministrationsViewsViews.UserControllers.PermittedUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 847);
            this.panelBottom.Size = new System.Drawing.Size(1510, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 697);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.permittedUserControl1);
            this.panelMain.Controls.Add(this.noPermissionUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1210, 697);
            // 
            // noPermissionUserControl1
            // 
            this.noPermissionUserControl1.Location = new System.Drawing.Point(276, 202);
            this.noPermissionUserControl1.Name = "noPermissionUserControl1";
            this.noPermissionUserControl1.Size = new System.Drawing.Size(934, 495);
            this.noPermissionUserControl1.TabIndex = 0;
            this.noPermissionUserControl1.Load += new System.EventHandler(this.NoPermisionLoad);
            // 
            // permittedUserControl1
            // 
            this.permittedUserControl1.Location = new System.Drawing.Point(233, 270);
            this.permittedUserControl1.Name = "permittedUserControl1";
            this.permittedUserControl1.Size = new System.Drawing.Size(1048, 244);
            this.permittedUserControl1.TabIndex = 1;
            // 
            // AdministrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 941);
            this.Name = "AdministrationView";
            this.Text = "AdministrationView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.NoPermissionUserControl noPermissionUserControl1;
        private UserControllers.PermittedUserControl permittedUserControl1;
    }
}