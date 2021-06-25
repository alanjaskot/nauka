
namespace nauka.V3.Views.SectionViews.Views
{
    partial class SectionAddView
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelDectionName = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(426, 69);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(267, 69);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelDectionName
            // 
            this.labelDectionName.AutoSize = true;
            this.labelDectionName.Location = new System.Drawing.Point(27, 18);
            this.labelDectionName.Name = "labelDectionName";
            this.labelDectionName.Size = new System.Drawing.Size(116, 25);
            this.labelDectionName.TabIndex = 2;
            this.labelDectionName.Text = "Nazwa działu";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Location = new System.Drawing.Point(202, 18);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(337, 31);
            this.textBoxSectionName.TabIndex = 3;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 118);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.labelDectionName);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Name = "SectionView";
            this.Text = "SectionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelDectionName;
        protected internal System.Windows.Forms.TextBox textBoxSectionName;
    }
}