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
    public partial class category_uc : UserControl
    {
        public category_uc(DataTable dt)
        {

            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                
                 bool res = GlobalVar.deleteExec("deleteCategoryItem", 1, new string[] {dataGridView1.SelectedCells[0].Value.ToString()}, new string[] { "id" });
         
                if(res)
                {
                    dataGridView1.DataSource =  GlobalVar.getData("select * from categories");
                }
           

            }
        }

        private void setCategory_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0)
            {
                categoryAdd categoryAdd = new categoryAdd(dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), false, dataGridView1.SelectedCells[0].Value.ToString());
                categoryAdd.ShowDialog();
            }
        }

        private void createCategory_Click(object sender, EventArgs e)
        {
            categoryAdd categoryAdd = new categoryAdd("", "", true, "");
            categoryAdd.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GlobalVar.getData("select * from categories");
        }
    }
}
