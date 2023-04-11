namespace WindowsFormsApp1
{
    partial class category_uc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createCategory = new System.Windows.Forms.Button();
            this.setCategory = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // createCategory
            // 
            this.createCategory.Location = new System.Drawing.Point(135, 383);
            this.createCategory.Name = "createCategory";
            this.createCategory.Size = new System.Drawing.Size(75, 23);
            this.createCategory.TabIndex = 1;
            this.createCategory.Text = "Add";
            this.createCategory.UseVisualStyleBackColor = true;
            this.createCategory.Click += new System.EventHandler(this.createCategory_Click);
            // 
            // setCategory
            // 
            this.setCategory.Location = new System.Drawing.Point(245, 383);
            this.setCategory.Name = "setCategory";
            this.setCategory.Size = new System.Drawing.Size(75, 23);
            this.setCategory.TabIndex = 2;
            this.setCategory.Text = "Set";
            this.setCategory.UseVisualStyleBackColor = true;
            this.setCategory.Click += new System.EventHandler(this.setCategory_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Location = new System.Drawing.Point(357, 383);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(75, 23);
            this.deleteCategory.TabIndex = 3;
            this.deleteCategory.Text = "Delete";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(31, 383);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // category_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.setCategory);
            this.Controls.Add(this.createCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "category_uc";
            this.Size = new System.Drawing.Size(578, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createCategory;
        private System.Windows.Forms.Button setCategory;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Button refresh;
    }
}
