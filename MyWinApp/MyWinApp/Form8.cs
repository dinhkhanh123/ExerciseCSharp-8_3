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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }
        public void CreateMyMainMenu()
        {
            MenuStrip menu = new MenuStrip();   
            this.Controls.Add(menu);
            this.MainMenuStrip = menu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem menuNew = new ToolStripMenuItem("&New");
            ToolStripMenuItem menuOpen = new ToolStripMenuItem("&Open");

            ToolStripSeparator separator = new ToolStripSeparator();

            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuAbout = new ToolStripMenuItem("&About");
            ToolStripMenuItem mnuViewAbout = new ToolStripMenuItem("&view About");

            //main menu
            menu.Items.AddRange(new ToolStripItem[] { menuFile, mnuAbout });
            //menu File
            menuFile.DropDownItems.AddRange(new ToolStripItem[] {menuNew,menuOpen,separator,mnuExit});

            //mnuAbout
            mnuAbout.DropDownItems.AddRange(new ToolStripItem[] { mnuViewAbout });
            //mnuNew
            menuNew.ShortcutKeys = (Keys)((Keys.Control | Keys.N));
            menuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            mnuExit.ShortcutKeys = (Keys)((Keys.Control | Keys.X));
            mnuExit.Click += new EventHandler(mnuExit_Click);
            //mnuViewAbout
            mnuViewAbout.ShortcutKeys = Keys.F1;
            mnuViewAbout.Click += new EventHandler(mnuViewDetail_Click);
        }

        private void mnuViewDetail_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Winform Application with .net", "About");
        }

        private void mnuExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
