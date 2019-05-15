using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sorting_Visualizer
{
    public class Algorithms
    {
        public async static void SelectionSort(Form1 form)
        {
            int aux = 0;

            for(int i = 0; i < form.values.Count(); i++)
            {
                aux = i;
                for (int i2 = i+1; i2 < form.values.Count(); i2++)
                {
                    if (form.values[i2] < form.values[aux])
                        aux = i2;
                }

                int min_num = form.values[aux];
                form.values[aux] = form.values[i];
                form.values[i] = min_num;
                await Task.Delay(form.vars.SORTING_TIME);
                //Console.Beep(i+1000, 10); Testing sound
                form.wait();
            }
        }
    }
}
