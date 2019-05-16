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
        Brush whiteBrush;
        Brush colorBrush;

        //Variables
        public List<int> values = new List<int>();
        public List<int> barColors = new List<int>();
        int arraySize = 246;  // 246 and array 1,2,1 for max (Default: 90, 6, 6, 6)
        public bool isSorted = true;

        public Common vars = new Common();

        //Rectangle Sizes
        int RECT_WIDTH = 1;
        int RECT_HEIGHT = 0;
        //int RECT_SPACING = 1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            whiteBrush = new SolidBrush(Color.White);
            cbbAlgos.SelectedIndex = 0;
            vars.SORTING_TIME = 40;
            RECT_HEIGHT = (this.Height - 10) / arraySize;
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
            Brush toUse;

            for(int i = 0; i < values.Count(); i++)
            {
                if (barColors[i] > 0)
                {
                    colorBrush = new SolidBrush(Color.FromArgb(255, 255 - barColors[i], 255 - barColors[i]));
                    toUse = colorBrush;
                }
                else
                    toUse = whiteBrush;

                if (barColors[i] > 0)
                    barColors[i] -= 85;

                Rectangle rect = new Rectangle(i * RECT_WIDTH + i, panel1.Height - values[i], RECT_WIDTH, values[i]);
                e.Graphics.FillRectangle(toUse, rect);
            }
        }

        //Fills the array with the initial values
        public void FillArray()
        {
            //Clears the array if its not empty already
            if (values.Count() > 0)
            {
                values.Clear();
                barColors.Clear();
            }

            for (int i = RECT_HEIGHT; i < arraySize * RECT_HEIGHT; i += RECT_HEIGHT)
            {
                values.Add(i);
                barColors.Add(0);
            }
        }

        //Randomizes the Array
        public void RandomizeArray()
        {
            isSorted = false;
            Random rand = new Random();
            int valueStore = 0;
            int idx = 0;

            barColors.Clear();

            for (int i = 0; i < values.Count(); i++)
            {
                barColors.Add(0);
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
            RECT_WIDTH = (panel1.Width - arraySize) / arraySize;
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
                case 1: Algorithms.InsertionSort(this); break;
                case 2: Algorithms.BogoSort(this); break;
                default: break;
            }
        }

        private void btnResetMS_Click(object sender, EventArgs e)
        {
            this.lblTime.Text = "Time: 40ms";
            this.tbTime.Value = 40;
        }

        private async void btnUpdateSize_Click(object sender, EventArgs e)
        {
            arraySize = (int)nupArraySize.Value + 1;
            GetRectangleSize();
            RECT_HEIGHT = (this.Height - 50) / arraySize;
            FillArray();
            await wait();
        }
    }
}
