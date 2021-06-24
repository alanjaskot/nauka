
namespace nauka.V3.Views.AdministrationsViewsViews.UserControllers
{
    partial class NoPermissionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNoPermisson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoPermisson
            // 
            this.labelNoPermisson.AutoSize = true;
            this.labelNoPermisson.Location = new System.Drawing.Point(193, 139);
            this.labelNoPermisson.Name = "labelNoPermisson";
            this.labelNoPermisson.Size = new System.Drawing.Size(171, 25);
            this.labelNoPermisson.TabIndex = 0;
            this.labelNoPermisson.Text = "Nie masz uprawnień";
            // 
            // NoPermissionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNoPermisson);
            this.Name = "NoPermissionUserControl";
            this.Size = new System.Drawing.Size(623, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoPermisson;
    }
}
