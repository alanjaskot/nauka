
namespace nauka.V3.Views.RegisterViews
{
    partial class RegisterView
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
            this.registerUserControl1 = new nauka.V3.Views.UserControllers.RegisterUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 642);
            this.panelBottom.Size = new System.Drawing.Size(1466, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(314, 492);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.registerUserControl1);
            this.panelMain.Location = new System.Drawing.Point(314, 150);
            this.panelMain.Size = new System.Drawing.Size(1152, 492);
            // 
            // registerUserControl1
            // 
            this.registerUserControl1.Location = new System.Drawing.Point(115, 0);
            this.registerUserControl1.Name = "registerUserControl1";
            this.registerUserControl1.Size = new System.Drawing.Size(617, 492);
            this.registerUserControl1.TabIndex = 0;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 736);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.RegisterUserControl registerUserControl1;
    }
}