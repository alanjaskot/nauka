
namespace nauka.V3.Views.AdministrationViews.SectionViews.SectionViews
{
    partial class SectionView
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
            this.labelSectionName = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSectionName.Location = new System.Drawing.Point(48, 45);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(77, 30);
            this.labelSectionName.TabIndex = 0;
            this.labelSectionName.Text = "Nazwa";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSectionName.Location = new System.Drawing.Point(167, 45);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(350, 37);
            this.textBoxSectionName.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.Location = new System.Drawing.Point(167, 132);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(404, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 197);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.labelSectionName);
            this.Name = "SectionView";
            this.Text = "SectionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSectionName;
        protected internal System.Windows.Forms.TextBox textBoxSectionName;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}