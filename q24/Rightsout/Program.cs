using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rightsout
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
			{
				1,
				7,
				16,
				11,
				14,
				19,
				20,
				18
			};

            int[] array2 = new int[]
			{
				85,
				111,
				117,
				43,
				104,
				127,
				117,
				117,
				33,
				110,
				99,
				43,
				72,
				95,
				85,
				85,
				94,
				66,
				120,
				98,
				79,
				117,
				68,
				83,
				64,
				94,
				39,
				65,
				73,
				32,
				65,
				72,
				51
			};
            string text = "";
            for (int j = 0; j < array2.Length; j++)
            {
                text += (char)(array2[j] ^ array[j % array.Length]);
            }

            Console.WriteLine(text);
        }
    }
}
