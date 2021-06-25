
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
            this.listViewSections.HideSelection = false;
            this.listViewSections.Location = new System.Drawing.Point(310, 148);
            this.listViewSections.Name = "listViewSections";
            this.listViewSections.Size = new System.Drawing.Size(316, 475);
            this.listViewSections.TabIndex = 0;
            this.listViewSections.UseCompatibleStateImageBehavior = false;
            // 
            // labelSectionList
            // 
            this.labelSectionList.AutoSize = true;
            this.labelSectionList.Location = new System.Drawing.Point(310, 85);
            this.labelSectionList.Name = "labelSectionList";
            this.labelSectionList.Size = new System.Drawing.Size(113, 25);
            this.labelSectionList.TabIndex = 1;
            this.labelSectionList.Text = "Lista działów";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(834, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 74);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Nowy  dział";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(834, 303);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(182, 74);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Zmień nazwę";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(834, 463);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 74);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń dział";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MenageSectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSectionList);
            this.Controls.Add(this.listViewSections);
            this.Name = "MenageSectionUC";
            this.Size = new System.Drawing.Size(1598, 780);
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
