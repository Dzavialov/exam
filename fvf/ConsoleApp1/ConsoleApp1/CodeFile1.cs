using System;
using System.Text;
using System.Linq;

namespace struct_ceh
{
    struct Ceh
    {
        public string workerName;
        public string cehName;
        public int amountA;
        public int amountB;
        public int amountC;
        public int priceA;
        public int priceB;
        public int priceC;

        public Ceh(string allData)
        {
            var arr = allData.Split(' ');

            workerName = arr[0] + " " + arr[1] + " " + arr[2];
            cehName = arr[3];
            amountA = Convert.ToInt32(arr[4]);
            amountB = Convert.ToInt32(arr[5]);
            amountC = Convert.ToInt32(arr[6]);
            priceA = Convert.ToInt32(arr[7]);
            priceB = Convert.ToInt32(arr[8]);
            priceC = Convert.ToInt32(arr[9]);
        }
    }
}
