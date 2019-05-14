using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Visualizer
{
    public partial class Form1 : Form
    {
        //Drawing Methods
        Graphics gfx;
        Brush myBrush;

        //Variables
        List<int> values = new List<int>();
        int arraySize = 100;

        //Rectangle Sizes
        int RECT_WIDTH = 1;
        //int RECT_SPACING = 1;

        public Form1()
        {
            InitializeComponent();
            gfx = panel1.CreateGraphics();
            myBrush = new SolidBrush(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillArray();
            GetRectangleSize();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < values.Count(); i++)
            {
                Rectangle rect = new Rectangle(i * RECT_WIDTH + i, panel1.Height-values[i], RECT_WIDTH, values[i]);
                gfx.FillRectangle(myBrush, rect);
            }
        }

        //Fills the array with the initial values
        public void FillArray()
        {
            //Clears the array if its not empty already
            if(values.Count() > 0)
                values.Clear();

            for (int i = 6; i < arraySize * 6; i += 6)
                values.Add(i);
        }

        //Randomizes the Array
        public void RandomizeArray()
        {
            Random rand = new Random();
            int valueStore = 0;
            int idx = 0;

            for (int i = 0; i < values.Count(); i++)
            {
                idx = rand.Next(0, values.Count());
                valueStore = values[idx];
                values[idx] = values[i];
                values[i] = valueStore;
            }
        }

        //Sorts array without using the proposed algorithm selection
        public void FastSortArray()
        {
            values.Sort();
        }

        public void GetRectangleSize()
        {
            RECT_WIDTH = (int)(panel1.Width - values.Count()) / values.Count();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            RandomizeArray();
            this.Refresh();
        }

        private void btnFastSort_Click(object sender, EventArgs e)
        {
            FastSortArray();
            this.Refresh();
        }
    }
}
