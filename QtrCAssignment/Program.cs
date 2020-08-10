using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtrCAssignment
{
    class Program
    {
        
        static void Main2(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] result = ReverseArray(arr);
            Console.WriteLine("stop");
        }

        //Question 1
        public static int ShowTicketsPrice(int[] ticketsArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int sum = 0;
            for (int i = 0; i < ticketsArray.Length; i++)
            {
                sum += ticketsArray[i] * ((i + 1) * 2);
            }
            return sum;
        }

        //Question 2.1
        public static bool SedimentAmount(int[] sedimentArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int sum = 0;
            for (int i = 0; i < sedimentArray.Length; i++)
            {
                sum += sedimentArray[i];
            }
            return sum > 100;
        }

        //Question 2.2
        public static int MaxSedimentAmount(int[] sedimentArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int max = sedimentArray[0];
            for (int i = 1; i < sedimentArray.Length; i++)
            {
                if (max < sedimentArray[i])
                    max = sedimentArray[i];
            }
            return max;
        }

        //Question 2.3
        public static bool IsOnlyOneMax(int[] sedimentArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int max = MaxSedimentAmount(sedimentArray);
            int count = 0;
            for (int i = 0; i < sedimentArray.Length; i++)
            {
                if (max == sedimentArray[i])
                    count++;
            }
            return count == 1;
        }

        //Question 3
        public static int[] ReverseArray(int[] originArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int countEven = 0, countOdd = 0, originLength=originArray.Length;
            int i;
            for (i = 0; i < originLength; i++)
            {
                if (originArray[i] % 2 == 0)
                    countEven++;
                else countOdd++;
            }
            int[] evenArr = new int[countEven], oddArr = new int[countOdd];
            countEven = 0;
            countOdd = 0;
            for (i=0; i < originLength; i++)
            {
                if (originArray[i]%2 == 0)
                {
                    evenArr[countEven] = originArray[i];
                    countEven++;
                }
                else
                {
                    oddArr[countOdd] = originArray[i];
                    countOdd++;
                }
            }

            for (i=0; i<originLength; i++)
            {
                if (i<countEven)
                {
                    originArray[i] = evenArr[i];
                }
                else
                {
                    originArray[i] = oddArr[i - countEven];
                }
            }
            return originArray;
        }

        //Question 4.1
        public static int PartialSum(int[] array, int index)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int sum = 0;
            for(int i=0; i<index; i++)
                sum += array[i];
            return sum;
        }

        //Question 4.2
        public static int[] PartialSumArray(int[] array)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int[] output = new int[array.Length+1];
            for (int i = 0; i < output.Length; i++)
                output[i] = PartialSum(array, i);
            return output;
        }

        //Question 5
        public static int[] NumOfEachDigit(int number)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int[] output = new int[10];
            if (number ==0)
            {
                output[0]++;
                return output;
            }
            while(number != 0)
            {
                output[number % 10]++;
                number = number / 10;
            }
            return output;
        }

        //Question 6.1
        public static int[] GettingNewArray(int size)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            return new int[size];
        }

        //Question 6.2
        public static int SumOfElements(int[] array)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //Question 6.3
        public static int NumOfLowElements(int[] array)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 56)
                    count++;
            return count;
        }

        //Question 6.4
        public static bool IsClassNormal(int[] classGradesArray)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            double length = (double)classGradesArray.Length;
            double avg = SumOfElements(classGradesArray) / length;
            double failPrecentage = (NumOfLowElements(classGradesArray) / length)*100;
            return avg > 70 && failPrecentage < 15;
        }

        //Question 7
        public static int IsSorted(int[] array)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            bool sortedUp = true, sortedDown = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i+1])
                {
                    sortedDown = false;
                    break;
                }
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1])
                {
                    sortedUp = false;
                    break;
                }
            }
            if (sortedUp)
                return 1;
            if (sortedDown)
                return -1;
            return 0;
        }

        //Question 8.1
        public static int NumOfDigits(int num)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int count = 0;
            if (num == 0)
                return 1;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }

        //Question 8.2
        public static int[] NumToArray(int num)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int[] output = new int[NumOfDigits(num)];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = num % 10;
                num /= 10;
            }
            return output;
        }

        //Question 9
        public static bool IsFlipping(bool[] array)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                    return false;
            }
            return true;
            
        }

        //Question 10.1
        public static int DigitInNumber(int number, int digit)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int count = 0;
            if (number == 0 && digit == 0)
                return 1;
            while (number != 0)
            {
                if (number % 10 == digit)
                    count++;
                number /= 10;
            }
            return count;
        }

        //Question 10.2
        public static int DigitInArray(int[] array, int digit)
        {
            //throw new NotImplementedException("Delete this line and instead write the code for this function");
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += DigitInNumber(array[i], digit);
            }
            return count;
        }

    }
}
