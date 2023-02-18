using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class HW2
    {

        public static void Run()
        {

           #region --Question 4-- 

            //--1 Inittializing Array of 10 Size
            int[] nums = new int[10];
            //numbersArr[0] = 1;
            //numbersArr[1] = 2;
            //numbersArr[2] = 3;
            //--2 Add Items to array
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i * 5;
               // Debug.WriteLine(i.ToString() +"----->"+nums[i].ToString());   
            }

            //-- Call JoinAll with All pArameters
            string joinText = JoinAll(nums);
            Console.WriteLine(joinText);


            List<int> lNumbers = GetListFromRowText("1_2_3_XXX_100_34535");

            #endregion

        }


        /// <summary>
        /// Convert Array to String Using _ Separator
        /// </summary>
        /// <example>
        /// [1 2 3] return 1_2_3
        /// </example>
        /// <param name="numbersArr">array Value</param>
        /// <returns>String with seperator</returns>
        public static string JoinAll(int[] numbersArr)
        {
            string joinText = "";
            for (int i = 0; i < numbersArr.Length; i++)
            {
               int val =  numbersArr[i];
               joinText += $"{val}_";
            }

            //joinText =  joinText.Substring(0, joinText.Length - 1);
            joinText = joinText.TrimEnd('_');
           
            return joinText;
        }

        /// <summary>
        /// 1_xxxx_100
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static List<int> GetListFromRowText(string row)
        {
            List<int> returnNumbers = new List<int>();
            string[] numbers = row.Split("_");//1_2_3
            foreach (string numberText in numbers)
            {
                //int number = int.Parse(numberText);
                int number;
                bool isConvertedOk = int.TryParse(numberText, out number);
                if (isConvertedOk)
                {
                    returnNumbers.Add(number);
                }
            }

            return returnNumbers;

        }






    }
}
