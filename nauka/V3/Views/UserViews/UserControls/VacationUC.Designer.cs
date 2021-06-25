
namespace nauka.V3.Views.UserViews.UserControls
{
    partial class VacationUC
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
            this.labelVacationList = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacations
            // 
            this.dataGridViewVacations.AllowUserToAddRows = false;
            this.dataGridViewVacations.AllowUserToDeleteRows = false;
            this.dataGridViewVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacations.Location = new System.Drawing.Point(110, 152);
            this.dataGridViewVacations.Name = "dataGridViewVacations";
            this.dataGridViewVacations.ReadOnly = true;
            this.dataGridViewVacations.RowHeadersWidth = 62;
            this.dataGridViewVacations.RowTemplate.Height = 33;
            this.dataGridViewVacations.Size = new System.Drawing.Size(460, 532);
            this.dataGridViewVacations.TabIndex = 0;
            // 
            // labelVacationList
            // 
            this.labelVacationList.AutoSize = true;
            this.labelVacationList.Location = new System.Drawing.Point(110, 94);
            this.labelVacationList.Name = "labelVacationList";
            this.labelVacationList.Size = new System.Drawing.Size(118, 25);
            this.labelVacationList.TabIndex = 1;
            this.labelVacationList.Text = "Lista urlopów";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(665, 152);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // VacationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelVacationList);
            this.Controls.Add(this.dataGridViewVacations);
            this.Name = "VacationUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewVacations;
        private System.Windows.Forms.Label labelVacationList;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
