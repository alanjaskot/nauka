
namespace nauka.V3.Views.UserControllers
{
    partial class VacationDisplayUserControl
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
            this.monthCalendarVacation = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewListOfDayFree = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfDayFree)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarVacation
            // 
            this.monthCalendarVacation.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendarVacation.Location = new System.Drawing.Point(468, 74);
            this.monthCalendarVacation.Name = "monthCalendarVacation";
            this.monthCalendarVacation.TabIndex = 0;
            // 
            // dataGridViewListOfDayFree
            // 
            this.dataGridViewListOfDayFree.AllowUserToAddRows = false;
            this.dataGridViewListOfDayFree.AllowUserToDeleteRows = false;
            this.dataGridViewListOfDayFree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfDayFree.Location = new System.Drawing.Point(85, 74);
            this.dataGridViewListOfDayFree.Name = "dataGridViewListOfDayFree";
            this.dataGridViewListOfDayFree.ReadOnly = true;
            this.dataGridViewListOfDayFree.RowHeadersWidth = 62;
            this.dataGridViewListOfDayFree.RowTemplate.Height = 33;
            this.dataGridViewListOfDayFree.Size = new System.Drawing.Size(360, 480);
            this.dataGridViewListOfDayFree.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(896, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 34);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Nowy urlop";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(896, 159);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(179, 34);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Zmień urlop";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(896, 243);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(179, 34);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Zrezygnuj";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // VacationDisplayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewListOfDayFree);
            this.Controls.Add(this.monthCalendarVacation);
            this.Name = "VacationDisplayUserControl";
            this.Size = new System.Drawing.Size(1122, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfDayFree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.MonthCalendar monthCalendarVacation;
        protected internal System.Windows.Forms.DataGridView dataGridViewListOfDayFree;
        protected internal System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonRemove;
    }
}
