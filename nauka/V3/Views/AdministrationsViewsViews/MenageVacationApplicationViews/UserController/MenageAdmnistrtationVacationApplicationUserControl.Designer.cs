
namespace nauka.V3.Views.AdministrationsViewsViews.AdministrationVacationViews.UserController
{
    partial class MenageAdmnistrtationVacationApplicationUserControl
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
            this.dataGridViewVacationApplication = new System.Windows.Forms.DataGridView();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelMenageVacationApplication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacationApplication
            // 
            this.dataGridViewVacationApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacationApplication.Location = new System.Drawing.Point(45, 62);
            this.dataGridViewVacationApplication.Name = "dataGridViewVacationApplication";
            this.dataGridViewVacationApplication.RowHeadersWidth = 62;
            this.dataGridViewVacationApplication.RowTemplate.Height = 33;
            this.dataGridViewVacationApplication.Size = new System.Drawing.Size(448, 410);
            this.dataGridViewVacationApplication.TabIndex = 0;
            // 
            // buttonApprove
            // 
            this.buttonApprove.Location = new System.Drawing.Point(532, 62);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(112, 34);
            this.buttonApprove.TabIndex = 1;
            this.buttonApprove.Text = "zatwierdź";
            this.buttonApprove.UseVisualStyleBackColor = true;
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(532, 125);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(112, 34);
            this.buttonReject.TabIndex = 2;
            this.buttonReject.Text = "Odrzuć";
            this.buttonReject.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(532, 194);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 34);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Zmień";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // labelMenageVacationApplication
            // 
            this.labelMenageVacationApplication.AutoSize = true;
            this.labelMenageVacationApplication.Location = new System.Drawing.Point(45, 19);
            this.labelMenageVacationApplication.Name = "labelMenageVacationApplication";
            this.labelMenageVacationApplication.Size = new System.Drawing.Size(194, 25);
            this.labelMenageVacationApplication.TabIndex = 4;
            this.labelMenageVacationApplication.Text = "Lista wniosków o urlop";
            // 
            // MenageAdmnistrtationVacationApplicationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMenageVacationApplication);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.dataGridViewVacationApplication);
            this.Name = "MenageAdmnistrtationVacationApplicationUserControl";
            this.Size = new System.Drawing.Size(749, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewVacationApplication;
        protected internal System.Windows.Forms.Button buttonApprove;
        protected internal System.Windows.Forms.Button buttonReject;
        protected internal System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelMenageVacationApplication;
    }
}
