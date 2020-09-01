using System;

namespace Sort
{
    class Pole
    {
        public int[] data { get; private set; }
        private Random rnd;
        private int iMin, iMax;
        public int velikostPole;

        public Pole(int velikost)
        {
            data = new int[velikost];
            rnd = new Random();
            iMax = 0;
            velikostPole = data.Length - 1;
            for(int i = 0; i < velikost; i++)
            {
                data[i] = rnd.Next(0, 1000);
            }
            iMin = data[0];
        }
        public override string ToString()
        {
            string s = "";
            foreach(int i in data)
            {
                s += i.ToString() + ",";
            }
            return s;
        }

        public void QuickSort(int Low, int High)
        {
            if(Low < High)
            {
                int pivot = tPivot(Low, High);
                QuickSort(Low, pivot - 1);
                QuickSort(pivot + 1, High);
            }

        }

        public int tPivot(int Low, int High)
        {
            int pivot = data[High];
            int i = Low - 1;
            for(int j =  Low; j < High; j++)
            {
                if(data[j] <= pivot)
                {
                    i++;
                    VymenData(i, j);
                }
            }
            VymenData(i + 1, High);
            return i + 1;
        }

        public void VymenData(int a, int b)
        {
            int temp = data[a];
            data[a] = data[b];
            data[b] = temp;
        }

    }
}
