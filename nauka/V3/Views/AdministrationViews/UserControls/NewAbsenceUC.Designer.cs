
namespace nauka.V3.Views.AdministrationViews.UserControls
{
    partial class NewAbsenceUC
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
            this.comboBoxSecitions = new System.Windows.Forms.ComboBox();
            this.buttonSectionChoose = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.listViewDescription = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSecitions
            // 
            this.comboBoxSecitions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSecitions.FormattingEnabled = true;
            this.comboBoxSecitions.Location = new System.Drawing.Point(56, 49);
            this.comboBoxSecitions.Name = "comboBoxSecitions";
            this.comboBoxSecitions.Size = new System.Drawing.Size(320, 38);
            this.comboBoxSecitions.TabIndex = 1;
            // 
            // buttonSectionChoose
            // 
            this.buttonSectionChoose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSectionChoose.Location = new System.Drawing.Point(431, 49);
            this.buttonSectionChoose.Name = "buttonSectionChoose";
            this.buttonSectionChoose.Size = new System.Drawing.Size(245, 38);
            this.buttonSectionChoose.TabIndex = 2;
            this.buttonSectionChoose.Text = "Pokaż pracowników";
            this.buttonSectionChoose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(56, 141);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(620, 565);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStart.Location = new System.Drawing.Point(838, 141);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(333, 31);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEnd.Location = new System.Drawing.Point(838, 228);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(333, 31);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // listViewDescription
            // 
            this.listViewDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewDescription.HideSelection = false;
            this.listViewDescription.Location = new System.Drawing.Point(838, 282);
            this.listViewDescription.Name = "listViewDescription";
            this.listViewDescription.Size = new System.Drawing.Size(333, 424);
            this.listViewDescription.TabIndex = 6;
            this.listViewDescription.UseCompatibleStateImageBehavior = false;
            this.listViewDescription.View = System.Windows.Forms.View.List;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(1264, 654);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 52);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(1264, 529);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 52);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(726, 142);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(39, 30);
            this.labelStart.TabIndex = 9;
            this.labelStart.Text = "od";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnd.Location = new System.Drawing.Point(726, 229);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(39, 30);
            this.labelEnd.TabIndex = 10;
            this.labelEnd.Text = "do";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(726, 282);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(81, 30);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "powód";
            // 
            // NewAbsenceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDescription);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.buttonSectionChoose);
            this.Controls.Add(this.comboBoxSecitions);
            this.Name = "NewAbsenceUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Button buttonSectionChoose;
        protected internal System.Windows.Forms.DataGridView dataGridViewEmployees;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerStart;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        protected internal System.Windows.Forms.ListView listViewDescription;
        protected internal System.Windows.Forms.Button buttonAdd;
        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.Label labelStart;
        protected internal System.Windows.Forms.Label labelEnd;
        protected internal System.Windows.Forms.Label labelDescription;
        protected internal System.Windows.Forms.ComboBox comboBoxSecitions;
    }
}
