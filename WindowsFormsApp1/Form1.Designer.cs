namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Бүх ангилал");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ангилал", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.sidebar = new System.Windows.Forms.TreeView();
            this.view = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Location = new System.Drawing.Point(12, 12);
            this.sidebar.Name = "sidebar";
            treeNode1.Name = "categoryView";
            treeNode1.Text = "Бүх ангилал";
            treeNode2.Name = "category";
            treeNode2.Text = "Ангилал";
            this.sidebar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.sidebar.Size = new System.Drawing.Size(192, 177);
            this.sidebar.TabIndex = 1;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(210, 12);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(578, 426);
            this.view.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view);
            this.Controls.Add(this.sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView sidebar;
        private System.Windows.Forms.Panel view;
    }
}

