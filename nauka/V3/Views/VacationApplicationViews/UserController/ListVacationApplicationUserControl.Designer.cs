
namespace nauka.V3.Views.UserControllers
{
    partial class ListVacationApplicationUserControl
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
            this.labelListOfVacationApplication = new System.Windows.Forms.Label();
            this.listViewVacationApplication = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListOfVacationApplication
            // 
            this.labelListOfVacationApplication.AutoSize = true;
            this.labelListOfVacationApplication.Location = new System.Drawing.Point(66, 52);
            this.labelListOfVacationApplication.Name = "labelListOfVacationApplication";
            this.labelListOfVacationApplication.Size = new System.Drawing.Size(209, 25);
            this.labelListOfVacationApplication.TabIndex = 0;
            this.labelListOfVacationApplication.Text = "Oczekuje na rozpatrzenie";
            // 
            // listViewVacationApplication
            // 
            this.listViewVacationApplication.HideSelection = false;
            this.listViewVacationApplication.Location = new System.Drawing.Point(66, 118);
            this.listViewVacationApplication.Name = "listViewVacationApplication";
            this.listViewVacationApplication.Size = new System.Drawing.Size(280, 337);
            this.listViewVacationApplication.TabIndex = 1;
            this.listViewVacationApplication.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(412, 118);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Nowy wniosek";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(412, 216);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(179, 34);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Zmień wniosek";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(412, 319);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 34);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Zrezygnuj";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // ListVacationApplicationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewVacationApplication);
            this.Controls.Add(this.labelListOfVacationApplication);
            this.Name = "ListVacationApplicationUserControl";
            this.Size = new System.Drawing.Size(679, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfVacationApplication;
        protected internal System.Windows.Forms.ListView listViewVacationApplication;
        protected internal System.Windows.Forms.Button buttonAdd;
        protected internal System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonDelete;
    }
}
