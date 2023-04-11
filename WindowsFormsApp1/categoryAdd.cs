using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class categoryAdd : Form
    {
        private bool isCreate;
        private string id;
        public bool IsCreate
        {
            get { return isCreate; }
            set { isCreate = value; }
        }
        public categoryAdd(string name, string desc, bool isCreate, string id)
        {
            InitializeComponent();
            categoryName.Text = name;
            this.isCreate= isCreate;
            description.Text = desc;
            this.id = id;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(this.isCreate)
            {
                bool res = GlobalVar.exec("createCategory", 2, new string[] { categoryName.Text, description.Text }, new string[] { "categoryName", "desc" });
                if (res)
                {
                    this.Hide();

                }
            } else
            {
                bool res = GlobalVar.exec("updateCategory", 3, new string[] { categoryName.Text, description.Text, this.id }, new string[] { "categoryName", "desc", "id" });
                if (res)
                {
                    this.Hide();

                }
            }
          
        }

    }
}
