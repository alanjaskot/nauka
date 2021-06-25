
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class PermissionUC
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.labelSections = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.checkBoxVacations = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(223, 168);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(462, 527);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(223, 83);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(462, 38);
            this.comboBoxSections.TabIndex = 1;
            this.comboBoxSections.Text = " działy";
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSections.Location = new System.Drawing.Point(44, 82);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(71, 30);
            this.labelSections.TabIndex = 2;
            this.labelSections.Text = "Działy";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPermission.Location = new System.Drawing.Point(904, 168);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(213, 32);
            this.labelPermission.TabIndex = 3;
            this.labelPermission.Text = "Nadaj uprawnienia";
            // 
            // checkBoxVacations
            // 
            this.checkBoxVacations.AutoSize = true;
            this.checkBoxVacations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacations.Location = new System.Drawing.Point(904, 284);
            this.checkBoxVacations.Name = "checkBoxVacations";
            this.checkBoxVacations.Size = new System.Drawing.Size(144, 36);
            this.checkBoxVacations.TabIndex = 4;
            this.checkBoxVacations.Text = "   wakacje";
            this.checkBoxVacations.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(904, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 36);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "   pracownicy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PermissionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxVacations);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.labelSections);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "PermissionUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewEmployees;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        private System.Windows.Forms.Label labelSections;
        private System.Windows.Forms.Label labelPermission;
        protected internal System.Windows.Forms.CheckBox checkBoxVacations;
        protected internal System.Windows.Forms.CheckBox checkBox1;
    }
}
