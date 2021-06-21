
namespace nauka.V2.Views.VacationDays.Views
{
    partial class VacationDaysView
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
            this.labelStartVacation = new System.Windows.Forms.Label();
            this.labelEndVacation = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartVacation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndVacation = new System.Windows.Forms.DateTimePicker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewVacationDays = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationDays)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartVacation
            // 
            this.labelStartVacation.AutoSize = true;
            this.labelStartVacation.Location = new System.Drawing.Point(29, 36);
            this.labelStartVacation.Name = "labelStartVacation";
            this.labelStartVacation.Size = new System.Drawing.Size(34, 25);
            this.labelStartVacation.TabIndex = 0;
            this.labelStartVacation.Text = "od";
            // 
            // labelEndVacation
            // 
            this.labelEndVacation.AutoSize = true;
            this.labelEndVacation.Location = new System.Drawing.Point(29, 98);
            this.labelEndVacation.Name = "labelEndVacation";
            this.labelEndVacation.Size = new System.Drawing.Size(34, 25);
            this.labelEndVacation.TabIndex = 1;
            this.labelEndVacation.Text = "do";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(29, 161);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(49, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(143, 161);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(300, 31);
            this.textBoxDescription.TabIndex = 3;
            // 
            // dateTimePickerStartVacation
            // 
            this.dateTimePickerStartVacation.Location = new System.Drawing.Point(143, 36);
            this.dateTimePickerStartVacation.Name = "dateTimePickerStartVacation";
            this.dateTimePickerStartVacation.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerStartVacation.TabIndex = 4;
            // 
            // dateTimePickerEndVacation
            // 
            this.dateTimePickerEndVacation.Location = new System.Drawing.Point(143, 98);
            this.dateTimePickerEndVacation.Name = "dateTimePickerEndVacation";
            this.dateTimePickerEndVacation.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerEndVacation.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(143, 331);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(295, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVacationDays
            // 
            this.dataGridViewVacationDays.AllowUserToAddRows = false;
            this.dataGridViewVacationDays.AllowUserToDeleteRows = false;
            this.dataGridViewVacationDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacationDays.Location = new System.Drawing.Point(482, 36);
            this.dataGridViewVacationDays.Name = "dataGridViewVacationDays";
            this.dataGridViewVacationDays.ReadOnly = true;
            this.dataGridViewVacationDays.RowHeadersWidth = 62;
            this.dataGridViewVacationDays.RowTemplate.Height = 33;
            this.dataGridViewVacationDays.Size = new System.Drawing.Size(524, 329);
            this.dataGridViewVacationDays.TabIndex = 8;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(143, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 34);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(295, 258);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 34);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // VacationDaysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 376);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewVacationDays);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dateTimePickerEndVacation);
            this.Controls.Add(this.dateTimePickerStartVacation);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEndVacation);
            this.Controls.Add(this.labelStartVacation);
            this.Name = "VacationDaysView";
            this.Text = "VacationDaysView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartVacation;
        private System.Windows.Forms.Label labelEndVacation;
        private System.Windows.Forms.Label labelDescription;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerStartVacation;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerEndVacation;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.TextBox textBoxDescription;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacationDays;
        protected internal System.Windows.Forms.Button buttonDelete;
        protected internal System.Windows.Forms.Button buttonEdit;
    }
}