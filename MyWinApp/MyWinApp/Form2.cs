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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void DisplayImage()
        {
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Width = 398;
            //pictureBox.Height = 223;
            //pictureBox.Location = new Point(0, 100);

            //Bitmap bitmap = new Bitmap(@"C:\Image\_MG_8303.jpg");
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Image = (Image)bitmap;
            //Controls.Add(pictureBox);

            ImageList imageList = new ImageList();  
            Image image1 = Image.FromFile(@"C:\Image\_MG_8303.jpg");
            Image image2 = Image.FromFile(@"C:\Image\image1.jpg");
            imageList.Images.AddRange(new Image[] { image1, image2 });  
            imageList.ImageSize = new Size(200, 200);   

        }
    }
}
