using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        private static int lastResult = 0;

        public static int Add(params int[] nums)
        {
            int result = 0;

            if (nums.Length <= 1)
            {
                result = lastResult + nums[0];
            }
            else
            {
                foreach (int num in nums)
                {
                    result += num;
                }
            }


            lastResult = result;
            return result;
        }

        public static int Subtract(params int[] nums)
        {
            int result = nums[0];

            if (nums.Length <= 1)
            {
                result = lastResult - nums[0];
            }
            else
            {
                foreach (int num in nums.Skip(1))
                {
                    result -= num;
                }
            }


            lastResult = result;
            return result;
        }

        public static int Multiply(params int[] nums)
        {
            int result = nums[0];

            if (nums.Length <= 1)
            {
                result = lastResult * nums[0];
            }
            else
            {
                foreach (int num in nums.Skip(1))
                {
                    result *= num;
                }
            }


            lastResult = result;
            return result;
        }

        public static int Divide(params int[] nums)
        {
            int result = nums[0];

            if (nums.Length <= 1)
            {
                result = lastResult / nums[0];
            }
            else
            {
                foreach (int num in nums.Skip(1))
                {
                    result /= num;
                }
            }


            lastResult = result;
            return result;
        }
    }
}