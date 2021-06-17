﻿
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
            this.SuspendLayout();
            // 
            // labelStartVacation
            // 
            this.labelStartVacation.AutoSize = true;
            this.labelStartVacation.Location = new System.Drawing.Point(83, 78);
            this.labelStartVacation.Name = "labelStartVacation";
            this.labelStartVacation.Size = new System.Drawing.Size(34, 25);
            this.labelStartVacation.TabIndex = 0;
            this.labelStartVacation.Text = "od";
            // 
            // labelEndVacation
            // 
            this.labelEndVacation.AutoSize = true;
            this.labelEndVacation.Location = new System.Drawing.Point(83, 140);
            this.labelEndVacation.Name = "labelEndVacation";
            this.labelEndVacation.Size = new System.Drawing.Size(34, 25);
            this.labelEndVacation.TabIndex = 1;
            this.labelEndVacation.Text = "do";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(83, 203);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(49, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(197, 203);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(545, 31);
            this.textBoxDescription.TabIndex = 3;
            // 
            // dateTimePickerStartVacation
            // 
            this.dateTimePickerStartVacation.Location = new System.Drawing.Point(197, 78);
            this.dateTimePickerStartVacation.Name = "dateTimePickerStartVacation";
            this.dateTimePickerStartVacation.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerStartVacation.TabIndex = 4;
            // 
            // dateTimePickerEndVacation
            // 
            this.dateTimePickerEndVacation.Location = new System.Drawing.Point(197, 140);
            this.dateTimePickerEndVacation.Name = "dateTimePickerEndVacation";
            this.dateTimePickerEndVacation.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerEndVacation.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(197, 279);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(349, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // VacationDaysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}