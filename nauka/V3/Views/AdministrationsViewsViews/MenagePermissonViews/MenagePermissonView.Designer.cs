
namespace nauka.V3.Views.AdministrationsViewsViews.MenagePermissonViews
{
    partial class MenagePermissonView
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
            this.viewEmployeeUserControl1 = new nauka.V3.Views.UserControllers.ViewEmployeeUserControl();
            this.menagePermissonUserControl1 = new nauka.V3.Views.AdministrationsViewsViews.MenagePermissonViews.UserController.MenagePermissonUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 648);
            this.panelBottom.Size = new System.Drawing.Size(1491, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 498);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.menagePermissonUserControl1);
            this.panelMain.Controls.Add(this.viewEmployeeUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1191, 498);
            // 
            // viewEmployeeUserControl1
            // 
            this.viewEmployeeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.viewEmployeeUserControl1.Name = "viewEmployeeUserControl1";
            this.viewEmployeeUserControl1.Size = new System.Drawing.Size(459, 498);
            this.viewEmployeeUserControl1.TabIndex = 0;
            // 
            // menagePermissonUserControl1
            // 
            this.menagePermissonUserControl1.Location = new System.Drawing.Point(475, 0);
            this.menagePermissonUserControl1.Name = "menagePermissonUserControl1";
            this.menagePermissonUserControl1.Size = new System.Drawing.Size(243, 505);
            this.menagePermissonUserControl1.TabIndex = 1;
            // 
            // MenagePermissonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 742);
            this.Name = "MenagePermissonView";
            this.Text = "MenagePermissonView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControllers.ViewEmployeeUserControl viewEmployeeUserControl1;
        private UserController.MenagePermissonUserControl menagePermissonUserControl1;
    }
}