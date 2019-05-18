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
            int aux = form.vars.SORTING_TIME;

            form.vars.SORTING_TIME = 10;

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

            form.vars.SORTING_TIME = aux;
        }

        //------------------------------------------ALGORITHMS------------------------------------------

        //SELECTION SORT
        public async static void SelectionSort(Form1 form)
        {
            if (!form.isSorted)
            {
                form.StartTimer();
                int aux = 0;
                for (int i = 0; i < form.values.Count(); i++)
                {
                    aux = i;
                    //form.array_accesses++;

                    for (int j = i + 1; j < form.values.Count(); j++)
                    {
                        //form.array_accesses+=2;
                        form.barColors[i] = 255;

                        form.array_comparisons++;
                        if (form.values[j] < form.values[aux])
                            aux = j;
                    }

                    form.barColors[aux] = 255;

                    int min_num = form.values[aux];
                    form.values[aux] = form.values[i];
                    form.values[i] = min_num;

                    //form.array_accesses+=3;

                    await form.wait();
                }
                form.isSorted = true;
                form.StopTimer();
            }
            FinalizeSort(form);
        }

        //INSERTION SORT
        public async static void InsertionSort(Form1 form)
        {
            if (!form.isSorted)
            {
                form.StartTimer();
                for (int i = 1; i < form.values.Count(); ++i)
                {
                    int aux = form.values[i];
                    int j = i - 1;

                    while (j >= 0 && form.values[j] > aux)
                    {
                        form.array_comparisons++;
                        form.barColors[i] = 255;
                        form.values[j + 1] = form.values[j];
                        j = j - 1;
                    }
                    form.values[j + 1] = aux;
                    form.barColors[j+1] = 255;

                    await form.wait();
                }
                form.isSorted = true;
                form.StopTimer();
            }
            FinalizeSort(form);
        }

        public async static void BogoSort(Form1 form)
        {
            form.StartTimer();
            while (!form.isSorted) {
                Random rand = new Random();
                int valueStore = 0;
                int idx = 0;

                //Randomize the Array
                for (int i = 0; i < form.values.Count(); i++)
                {
                    idx = rand.Next(0, form.values.Count());
                    valueStore = form.values[idx];
                    form.values[idx] = form.values[i];
                    form.values[i] = valueStore;

                    form.barColors[idx] = 255;
                }

                form.array_comparisons++;
                //Check if is sorted
                if (CheckIfSorted(form))
                {
                    form.isSorted = true;
                    form.StopTimer();
                }

                await form.wait();
            }
            FinalizeSort(form);
        }

        public async static void BubbleSort(Form1 form)
        {
            if (!form.isSorted)
            {
                form.StartTimer();
                int aux = -1;
                for(int i = 0; i < form.values.Count(); i++)
                {
                    for(int j = 1; j < form.values.Count()-i; ++j)
                    {
                        form.array_comparisons++;
                        if(form.values[j-1] > form.values[j])
                        {
                            int num = form.values[j];
                            form.values[j] = form.values[j - 1];
                            form.values[j-1] = num;

                            form.barColors[j] = 255;
                            form.barColors[j-1] = 255;
                            aux++;
                        }
                    }
                    await form.wait();
                }
                form.isSorted = true;
                form.StopTimer();
            }
            FinalizeSort(form);
        }

        //Check if is sorted
        static bool CheckIfSorted(Form1 form)
        {
            for (int i = 1; i < form.values.Count(); ++i)
                if (form.values[i] < form.values[i - 1]) return false;
            return true;
        }
    }
}
