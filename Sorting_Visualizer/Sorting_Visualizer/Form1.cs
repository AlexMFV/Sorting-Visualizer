using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Visualizer
{
    public partial class Form1 : Form
    {
        //Drawing Methods
        Brush myBrush;

        //Variables
        public List<int> values = new List<int>();
        int arraySize = 246;

        public Common vars = new Common();

        //Rectangle Sizes
        int RECT_WIDTH = 1;
        //int RECT_SPACING = 1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            myBrush = new SolidBrush(Color.White);
            cbbAlgos.SelectedIndex = 0;
            vars.SORTING_TIME = 150;
        }

        public async Task wait()
        {
            await Task.Delay(vars.SORTING_TIME);
            this.Refresh();
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
                e.Graphics.FillRectangle(myBrush, rect);
            }
        }

        //Fills the array with the initial values
        public void FillArray()
        {
            //Clears the array if its not empty already
            if(values.Count() > 0)
                values.Clear();

            for (int i = 1; i < arraySize * 2; i += 1)
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

        private void tbTime_ValueChanged(object sender, EventArgs e)
        {
            lblTime.Text = "Time: " + tbTime.Value + "ms";
            vars.SORTING_TIME = tbTime.Value;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (cbbAlgos.SelectedIndex)
            {
                case 0: Algorithms.SelectionSort(this); break;
                default: break;
            }
        }
    }
}
