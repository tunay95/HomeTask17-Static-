using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask17_Static_
{
    internal static class ExtensionMethods
    {
        public static bool CustomContains(this string word, string findString)
        {
            int lengthFind = findString.Length;
            bool checkFind = false;

            if (word.Length < lengthFind)
            {
                checkFind = false;
            }
            else
            {
                int index = 0;
                while (word.Length >= index + lengthFind)
                {
                    if (word.Substring(index, lengthFind) == findString)
                    {
                        checkFind = true;
                        break;
                    }
                    else
                    {
                        index++;
                    }
                }
            }

            return checkFind;
        }
    

        public static bool CustomConstains(this string word, char findChar)
        {

            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (findChar == word[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }


        public static bool IsPrime(int number)
        {
            bool check = false;
            int count = 0;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;             //bolenlerinin sayi
                }

            }
            if (count != 0)
            {
                check = true;
                return check;
            }
            return check;
        }
        public static bool IsPowOfTwo(this int number)
        {
            int num2 = 0;

            if (num2 == 1)
            { 
            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    num2 = number;
                    break;
                }
                number /= 2;
            }
                return true; 
            }
            else
            {
                return false;
            }

        }


    }
}
}
