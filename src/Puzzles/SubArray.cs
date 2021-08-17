using System;
using System.Collections.Generic;

namespace CSample.Puzzles
{
    public class SubArray
    {
        private List<int> chocBar = new List<int>();
        private readonly int month; 
        private readonly int day;
        private int NoOfWays = 0;

        public SubArray(List<int> chocBar, int month, int day)
        {
          this.chocBar = chocBar;
          this.month = month;
          this.day = day;
        }

        public int NoOfWaysBarDivided()
        {
            
            for (int i = 0; i < chocBar.Count -month + 1; i++)
            {
                int sum = 0;

                for(int j=i; j< i+month; j++)
                {
                    sum += chocBar[j];    
                }
                if (sum == day)
                    NoOfWays++;

            }
            return NoOfWays;
        }

    }
}
