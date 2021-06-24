
namespace nauka.V3.Views.EmplyeeViews
{
    partial class EmloyeeView
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
            this.leftPanelUserControl1 = new nauka.V3.Views.UserControllers.LeftPanelUserControl();
            this.singleEmployeeUserControl1 = new nauka.V3.Views.UserControllers.SingleEmployeeUserControl();
            this.panelBottom.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 671);
            this.panelBottom.Size = new System.Drawing.Size(1452, 94);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.leftPanelUserControl1);
            this.panelLeftMenu.Size = new System.Drawing.Size(314, 521);
            this.panelLeftMenu.Controls.SetChildIndex(this.leftPanelUserControl1, 0);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.singleEmployeeUserControl1);
            this.panelMain.Location = new System.Drawing.Point(314, 150);
            this.panelMain.Size = new System.Drawing.Size(1138, 521);
            // 
            // leftPanelUserControl1
            // 
            this.leftPanelUserControl1.Location = new System.Drawing.Point(0, 0);
            this.leftPanelUserControl1.Name = "leftPanelUserControl1";
            this.leftPanelUserControl1.Size = new System.Drawing.Size(314, 521);
            this.leftPanelUserControl1.TabIndex = 0;
            // 
            // singleEmployeeUserControl1
            // 
            this.singleEmployeeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.singleEmployeeUserControl1.Name = "singleEmployeeUserControl1";
            this.singleEmployeeUserControl1.Size = new System.Drawing.Size(438, 521);
            this.singleEmployeeUserControl1.TabIndex = 0;
            // 
            // EmloyeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 765);
            this.Name = "EmloyeeView";
            this.Text = "EmloyeeView";
            this.panelBottom.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControllers.LeftPanelUserControl leftPanelUserControl1;
        private UserControllers.SingleEmployeeUserControl singleEmployeeUserControl1;
    }
}