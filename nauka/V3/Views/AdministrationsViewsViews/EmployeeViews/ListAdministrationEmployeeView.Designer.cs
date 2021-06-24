
namespace nauka.V3.Views.AdministrationsViewsViews.ListAdministrationEmployeeViews
{
    partial class ListAdministrationEmployeeView
    {
        private bool isMenageUserUsed = false;
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
            this.menageEmployeeUserControl1 = new nauka.V3.Views.UserControllers.MenageEmployeeUserControl();
            this.setEmployeeUserControl1 = new nauka.V3.Views.UserControllers.SetEmployeeUserControl();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 666);
            this.panelBottom.Size = new System.Drawing.Size(1509, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 516);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.setEmployeeUserControl1);
            this.panelMain.Controls.Add(this.menageEmployeeUserControl1);
            this.panelMain.Controls.Add(this.viewEmployeeUserControl1);
            this.panelMain.Size = new System.Drawing.Size(1209, 516);
            // 
            // viewEmployeeUserControl1
            // 
            this.viewEmployeeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.viewEmployeeUserControl1.Name = "viewEmployeeUserControl1";
            this.viewEmployeeUserControl1.Size = new System.Drawing.Size(446, 516);
            this.viewEmployeeUserControl1.TabIndex = 0;
            // 
            // menageEmployeeUserControl1
            // 
            this.menageEmployeeUserControl1.Location = new System.Drawing.Point(452, 0);
            this.menageEmployeeUserControl1.Name = "menageEmployeeUserControl1";
            this.menageEmployeeUserControl1.Size = new System.Drawing.Size(273, 516);
            this.menageEmployeeUserControl1.TabIndex = 1;
            // 
            // setEmployeeUserControl1
            // 
            this.setEmployeeUserControl1.Location = new System.Drawing.Point(47, 0);
            this.setEmployeeUserControl1.Name = "setEmployeeUserControl1";
            this.setEmployeeUserControl1.Size = new System.Drawing.Size(645, 696);
            this.setEmployeeUserControl1.TabIndex = 2;
            // 
            // ListAdministrationEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 760);
            this.Name = "ListAdministrationEmployeeView";
            this.Text = "ListAdministrationEmployeeView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControllers.ViewEmployeeUserControl viewEmployeeUserControl1;
        private Views.UserControllers.MenageEmployeeUserControl menageEmployeeUserControl1;
        private Views.UserControllers.SetEmployeeUserControl setEmployeeUserControl1;

        public void SetIsMenageUserUsed(bool setUserEdit)
        {
            if (setUserEdit)
            {
                isMenageUserUsed = true;
            }
            else
            {
                isMenageUserUsed = true;
            }
        }

        private void DisplayUserControllers()
        {
            if (!isMenageUserUsed)
            {
                setEmployeeUserControl1.Hide();
                viewEmployeeUserControl1.Show();
                menageEmployeeUserControl1.Show();
            }
            else
            {
                setEmployeeUserControl1.Show();
                viewEmployeeUserControl1.Hide();
                menageEmployeeUserControl1.Hide();
            }
        }
    }
}