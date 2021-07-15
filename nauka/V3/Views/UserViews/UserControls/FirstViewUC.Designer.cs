
namespace nauka.V3.Views.UserViews.UserControls
{
    partial class FirstViewUC
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
            this.labelWelcomSign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcomSign
            // 
            this.labelWelcomSign.AutoSize = true;
            this.labelWelcomSign.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcomSign.Location = new System.Drawing.Point(387, 250);
            this.labelWelcomSign.Name = "labelWelcomSign";
            this.labelWelcomSign.Size = new System.Drawing.Size(537, 45);
            this.labelWelcomSign.TabIndex = 0;
            this.labelWelcomSign.Text = "Witaj w panelu zarządzania urlopami";
            // 
            // FirstViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWelcomSign);
            this.Name = "FirstViewUC";
            this.Size = new System.Drawing.Size(1578, 742);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label labelWelcomSign;
    }
}
