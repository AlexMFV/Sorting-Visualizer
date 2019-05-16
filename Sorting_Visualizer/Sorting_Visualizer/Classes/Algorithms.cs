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
        public async static void FinalizeSort(Form1 form)
        {
            for (int i = 0; i < form.values.Count(); i++)
            {
                form.barColors[i] = 255;
                await form.wait();
            }

            //Final refresh to remove the last red bars
            for (int i = 0; i < form.barColors.Count(); i++)
            {
                while (form.barColors[i] > 0)
                    form.barColors[i] -= 85;
                await form.wait();
            }
        }

        //------------------------------------------ALGORITHMS------------------------------------------

        //SELECTION SORT
        public async static void SelectionSort(Form1 form)
        {
            if (!form.isSorted)
            {
                int aux = 0;
                for (int i = 0; i < form.values.Count(); i++)
                {
                    aux = i;

                    for (int j = i + 1; j < form.values.Count(); j++)
                    {
                        form.barColors[i] = 255;
                        if (form.values[j] < form.values[aux])
                            aux = j;
                    }

                    form.barColors[aux] = 255;

                    int min_num = form.values[aux];
                    form.values[aux] = form.values[i];
                    form.values[i] = min_num;
                    
                    await form.wait();
                }
                form.isSorted = true;
            }
            FinalizeSort(form);
        }

        //INSERTION SORT
        public async static void InsertionSort(Form1 form)
        {
            if (!form.isSorted)
            {
                for (int i = 1; i < form.values.Count(); ++i)
                {
                    int aux = form.values[i];
                    int j = i - 1;

                    while (j >= 0 && form.values[j] > aux)
                    {
                        form.barColors[i] = 255;
                        form.values[j + 1] = form.values[j];
                        j = j - 1;
                    }
                    form.values[j + 1] = aux;
                    form.barColors[j+1] = 255;

                    await form.wait();
                }
                form.isSorted = true;
            }
            FinalizeSort(form);
        }
    }
}
