
namespace nauka.V3.BaseViews
{
    partial class baseView
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.leftPanelUserControl1 = new nauka.V3.Views.UserControllers.LeftPanelUserControl();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBottom.Controls.Add(this.buttonCancel);
            this.panelBottom.Controls.Add(this.buttonOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 655);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1543, 94);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1151, 35);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1300, 35);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 34);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1543, 150);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1543, 150);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "AppTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.leftPanelUserControl1);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 150);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 505);
            this.panelLeftMenu.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(300, 150);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1243, 505);
            this.panelMain.TabIndex = 3;
            // 
            // leftPanelUserControl1
            // 
            this.leftPanelUserControl1.Location = new System.Drawing.Point(0, 0);
            this.leftPanelUserControl1.Name = "leftPanelUserControl1";
            this.leftPanelUserControl1.Size = new System.Drawing.Size(300, 505);
            this.leftPanelUserControl1.TabIndex = 0;
            // 
            // baseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 749);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "baseView";
            this.Text = "baseView";
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Panel panelBottom;
        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        protected internal System.Windows.Forms.Panel panelLeftMenu;
        protected internal System.Windows.Forms.Panel panelMain;
        private Views.UserControllers.LeftPanelUserControl leftPanelUserControl1;
    }
}