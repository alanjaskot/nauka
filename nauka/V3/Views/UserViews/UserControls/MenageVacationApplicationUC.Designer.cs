
namespace nauka.V3.Views.UserViews.UserControls
{
    partial class MenageVacationApplicationUC
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
            this.dataGridViewVacAppList = new System.Windows.Forms.DataGridView();
            this.labelVacationApplicationList = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacAppList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacAppList
            // 
            this.dataGridViewVacAppList.AllowUserToAddRows = false;
            this.dataGridViewVacAppList.AllowUserToDeleteRows = false;
            this.dataGridViewVacAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacAppList.Location = new System.Drawing.Point(254, 148);
            this.dataGridViewVacAppList.Name = "dataGridViewVacAppList";
            this.dataGridViewVacAppList.ReadOnly = true;
            this.dataGridViewVacAppList.RowHeadersWidth = 62;
            this.dataGridViewVacAppList.RowTemplate.Height = 33;
            this.dataGridViewVacAppList.Size = new System.Drawing.Size(441, 538);
            this.dataGridViewVacAppList.TabIndex = 0;
            // 
            // labelVacationApplicationList
            // 
            this.labelVacationApplicationList.AutoSize = true;
            this.labelVacationApplicationList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacationApplicationList.Location = new System.Drawing.Point(254, 67);
            this.labelVacationApplicationList.Name = "labelVacationApplicationList";
            this.labelVacationApplicationList.Size = new System.Drawing.Size(165, 30);
            this.labelVacationApplicationList.TabIndex = 1;
            this.labelVacationApplicationList.Text = "Wnioski o urlop";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(855, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(211, 82);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Wniosek o urlop";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(855, 300);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(211, 82);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Zmień wniosek";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(855, 448);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(211, 103);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Zrezygnuj z wniosku";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MenageVacationApplicationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelVacationApplicationList);
            this.Controls.Add(this.dataGridViewVacAppList);
            this.Name = "MenageVacationApplicationUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacAppList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewVacAppList;
        private System.Windows.Forms.Label labelVacationApplicationList;
        protected internal System.Windows.Forms.Button buttonAdd;
        protected internal System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonDelete;
    }
}
