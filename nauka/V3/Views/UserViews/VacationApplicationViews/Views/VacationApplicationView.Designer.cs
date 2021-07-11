
namespace nauka.V3.Views.UserViews.VacationApplicationViews.Views
{
    partial class VacationApplicationView
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStart.Location = new System.Drawing.Point(122, 84);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(425, 37);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(26, 84);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(39, 30);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "od";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnd.Location = new System.Drawing.Point(26, 173);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(39, 30);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "do";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEnd.Location = new System.Drawing.Point(122, 173);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(425, 37);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscription.Location = new System.Drawing.Point(26, 255);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(53, 30);
            this.labelDiscription.TabIndex = 4;
            this.labelDiscription.Text = "opis";
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(122, 255);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(425, 38);
            this.comboBoxDescription.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.Location = new System.Drawing.Point(259, 348);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 49);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(435, 348);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 49);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // VacationApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxDescription);
            this.Controls.Add(this.labelDiscription);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "VacationApplicationView";
            this.Text = "VacationApplicationView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DateTimePicker dateTimePickerStart;
        protected internal System.Windows.Forms.Label labelStart;
        protected internal System.Windows.Forms.Label labelEnd;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        protected internal System.Windows.Forms.Label labelDiscription;
        protected internal System.Windows.Forms.ComboBox comboBoxDescription;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}