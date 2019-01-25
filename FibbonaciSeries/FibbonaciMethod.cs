using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciSeries
{
    class FibbonaciMethod
    {
        public List<int> GetFibbonnaciSolution(int n)
        {
           
            List<int> fibbonaciSeries = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i==0)
                {
                    fibbonaciSeries.Add(0);
                    continue;
                }
                if (i == 1)
                {
                    fibbonaciSeries.Add(1);
                    continue;
                }
                if(i>=2)
                {
                    fibbonaciSeries.Add(fibbonaciSeries[i - 1] + fibbonaciSeries[i - 2]);
                    
                }
                
                
            }
            return fibbonaciSeries;
        }
    }
}
