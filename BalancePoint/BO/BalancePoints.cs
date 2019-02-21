using BalancePoint.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePoint
{
    public class BalancePoints : Balance<int[],int>
    {
        public int Manage(int[] input)
        {
            int leftSum = input[0];
            int rightSum = 0; ;
            for (int i = 0; i < input.Length; i++)
                rightSum += input[i];

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (leftSum == rightSum)
                    return i;
                leftSum += input[i + 1];
                rightSum -= input[i];
            }
            return -1;
        }



    }
}
