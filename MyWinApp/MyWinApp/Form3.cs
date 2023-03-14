using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDataTable_Click(object sender, EventArgs e)
        {
            DataTable products = new DataTable();   
            products.Columns.Add("ProductID",typeof(int));
            products.Columns.Add("ProductName",typeof(string));
            products.Columns.Add("UnitPrice",typeof(double));
            products.Rows.Add(1,"Mouse",20.8);
            products.Rows.Add(2,"Keyboard",30.5);
            dgvProducts.DataSource = products;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>
            {
                new {ProductID = 3, ProductName = "Speaker",UnitPrice= 14.5},
                new {ProductID = 4, ProductName = "Monitor",UnitPrice= 50.5}

            };
            dgvProducts.DataSource = products;  
        }
    }
}
