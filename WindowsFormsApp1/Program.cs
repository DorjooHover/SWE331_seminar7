﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
     
        
        static void Main()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RK702O;Initial Catalog=Northwind;Integrated Security=True");
            GlobalVar.Connection= con;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
