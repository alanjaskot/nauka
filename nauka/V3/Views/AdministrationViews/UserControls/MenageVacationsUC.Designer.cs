
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class MenageVacationsUC
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
            this.dataGridViewVacations = new System.Windows.Forms.DataGridView();
            this.labelSections = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.buttonChooseSection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacations
            // 
            this.dataGridViewVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacations.Location = new System.Drawing.Point(99, 104);
            this.dataGridViewVacations.Name = "dataGridViewVacations";
            this.dataGridViewVacations.RowHeadersWidth = 62;
            this.dataGridViewVacations.RowTemplate.Height = 33;
            this.dataGridViewVacations.Size = new System.Drawing.Size(1000, 625);
            this.dataGridViewVacations.TabIndex = 0;
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSections.Location = new System.Drawing.Point(99, 42);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(71, 30);
            this.labelSections.TabIndex = 1;
            this.labelSections.Text = "Działy";
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(1263, 423);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(239, 55);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Dodaj";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(1263, 543);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(239, 55);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Zmień";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(1263, 674);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(239, 55);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(228, 39);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(349, 38);
            this.comboBoxSections.TabIndex = 6;
            // 
            // buttonChooseSection
            // 
            this.buttonChooseSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseSection.Location = new System.Drawing.Point(1263, 104);
            this.buttonChooseSection.Name = "buttonChooseSection";
            this.buttonChooseSection.Size = new System.Drawing.Size(239, 55);
            this.buttonChooseSection.TabIndex = 7;
            this.buttonChooseSection.Text = "Pokaż";
            this.buttonChooseSection.UseVisualStyleBackColor = true;
            // 
            // MenageVacationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChooseSection);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelSections);
            this.Controls.Add(this.dataGridViewVacations);
            this.Name = "MenageVacationsUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewVacations;
        protected internal System.Windows.Forms.Button buttonNew;
        protected internal System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonDelete;
        protected internal System.Windows.Forms.Label labelSections;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        protected internal System.Windows.Forms.Button buttonChooseSection;
    }
}
