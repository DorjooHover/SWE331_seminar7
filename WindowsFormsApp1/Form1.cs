using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            getData();
        }

        void getData()
        {
            DataTable dt = GlobalVar.getData("select * from categories");

            category_uc category = new category_uc(dt);
            view.Controls.Add(category);
        }

        
    }
}
