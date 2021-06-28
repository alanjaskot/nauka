
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class MenageSectionUC
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
            this.listViewSections = new System.Windows.Forms.ListView();
            this.labelSectionList = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSections
            // 
            this.listViewSections.AutoArrange = false;
            this.listViewSections.HideSelection = false;
            this.listViewSections.Location = new System.Drawing.Point(372, 178);
            this.listViewSections.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSections.Name = "listViewSections";
            this.listViewSections.ShowGroups = false;
            this.listViewSections.Size = new System.Drawing.Size(296, 569);
            this.listViewSections.TabIndex = 0;
            this.listViewSections.UseCompatibleStateImageBehavior = false;
            // 
            // labelSectionList
            // 
            this.labelSectionList.AutoSize = true;
            this.labelSectionList.Location = new System.Drawing.Point(372, 102);
            this.labelSectionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSectionList.Name = "labelSectionList";
            this.labelSectionList.Size = new System.Drawing.Size(135, 30);
            this.labelSectionList.TabIndex = 1;
            this.labelSectionList.Text = "Lista działów";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(1001, 178);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(218, 89);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Nowy  dział";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(1001, 364);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(218, 89);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Zmień nazwę";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(1001, 556);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(218, 89);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń dział";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MenageSectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSectionList);
            this.Controls.Add(this.listViewSections);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenageSectionUC";
            this.Size = new System.Drawing.Size(1918, 936);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ListView listViewSections;
        private System.Windows.Forms.Label labelSectionList;
        protected internal System.Windows.Forms.Button buttonAdd;
        protected internal System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonDelete;
    }
}
