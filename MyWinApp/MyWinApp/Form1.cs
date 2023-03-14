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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtEmployeeID.Text;
            string EmployeeName = txtEmpName.Text;  
            string Phone = mtxtPhone.Text;
            string Gender = (rdFemale.Checked ? "Female" : "Male");
            string Degree = cboDegree.Text;

            StringBuilder builder = new StringBuilder();
            builder.Append($"Employee ID : {EmployeeID} \n");
            builder.Append($"Employee Name : {EmployeeName} \n");
            builder.Append($"Phone : {Phone} \n");
            builder.Append($"Gender : {Gender}");
            builder.Append($"Degree : {Degree}");

            MessageBox.Show(builder.ToString(),"Employee Details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
