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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

     
        private void Form4_Load(object sender, EventArgs e)
        {
            CreateMyRichTextBox();
        }
       
        
        public void CreateMyRichTextBox()
        {
            RichTextBox rtbData = new RichTextBox();

            rtbData.Dock = DockStyle.Fill;
            rtbData.LoadFile(@"C:\Image\MyData.rtf");
            rtbData.Find("RichTextBox",RichTextBoxFinds.MatchCase);
            rtbData.SelectionFont = new Font("Verdana",12,FontStyle.Bold);
            rtbData.SelectionColor = Color.Red;
            rtbData.SaveFile("MyData.rtf",RichTextBoxStreamType.RichText);
            this.Controls.Add(rtbData);
        }

       
    }
}
