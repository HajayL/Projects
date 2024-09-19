using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static Mocha.Window window = new Mocha.Window(500, 500, 600, 600, "Temp window");

        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            window.instance.Position = new Point(this.Left, this.Top);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}


namespace Mocha
{
    class Window
    {
        public int x, y, width, height;
        private string name;
        public CDrawer instance;

        public Window(int x, int y, int width, int height, string name)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.name = name;

            instance = new CDrawer(width, height);
            instance.Position = new Point(x, y);
        }
    }
}