using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*******************************************************************
                        EXPLORATION OF C#
                        
                Created by: Ron Gerlan F. Naragdao
                        December 9, 2022
*******************************************************************/


/*******************************************************************
When using Visual Code Studio, type dotnet run in console to run C#.
*******************************************************************/

namespace Csharp
{
    public class SearchNSort
    {
        // this subprogram efficiently searches a value in the array
        public static int BinarySearch(int[] array, int wanted)
        {
            // the leftmost index of the array
            int start = 1;
            // the rightmost index of the array
            int end = array.Length;
            // the central index of the array
            int mid = 0;
            // handles the double type result in computing mid variable
            double d = 0;

            // while the array scope has at least length 1
            while (start<=end)
            {
                // compute for central index
                d = (start+end)/2;
                // use Ceiling method for result in d and use casting
                mid = (int)Math.Ceiling(d);
                // if the wanted value is at the center
                if (wanted == array[mid-1])
                {
                    return mid;
                }
                // if the wanted value is less than the central value
                else if (wanted < array[mid-1])
                {
                    // change end to be the left value adjacent of mid
                    end = --mid;
                }
                // if the wanted value is greater than the central value
                else if (wanted > array[mid-1])
                {
                    // change start to be the right value adjacent of mid
                    start = ++mid;
                }
            }
            // return -1 to signify unfound wanted value
            return -1;
        }

        // this subprogram sorts an array by swapping the leftmost value covered with the smallest data among the remaining values.
        public static void SelectionSort(ref int[] array)
        {
            // smallest variable to hold smallest data
            // placeholder variable to hold temporary data for swapping
            int smallest, placeholder;

            // for item range from index 1,2,..,n to index n
            for(int index1 = 0; index1 < array.Length-1; index1++)
            {
                // set index1 as smallest data at first
                smallest = index1;
                // for item range from index 2,3,..,n to index n
                for(int index2 = index1+1; index2 < array.Length; index2++)
                {
                    // if a value in array is less than the smallest in array
                    if(array[index2]<array[smallest])
                    {
                        // set value found as new smallest
                        smallest = index2;
                    }
                }
                // swap new smallest with leftmost covered index
                placeholder = array[smallest];
                array[smallest] = array[index1];
                array[index1] = placeholder;
            }
        }

        // this subprogram sorts an array by swapping from left to right of array the two values adjacent to each other.
        public static void BubbleSort(ref int[] array)
        {
            // flag variable is used to flag if there are swaps occured
            bool flag = false;
            // index1 variable is the first index compared
            int index1 = 0;
            // index2 variable is the second index compared
            int index2;
            // placeholder variable to hold temporary data for swapping
            int placeholder;

            // iterate the whole array one by one
            while(true)
            {
                // while swapping occurs
                while(true)
                {
                    // set index2 as the next index of index1
                    index2 = index1+1;
                    
                    // if index2 is out of bounds
                    if(index2==array.Length)
                    {
                        // set index1 back to 0
                        index1 = 0;
                        // break out of the loop
                        break;
                    }
                    // if index2 is less than index1 in the array
                    if(array[index2]<array[index1])
                    {
                        // temporarily store data of index2 in array
                        placeholder = array[index2];
                        // replace value in index2 with index1 in array
                        array[index2] = array[index1];
                        // store data of placeholder data in index1
                        array[index1] = placeholder;
                        // set flag as true if swap occured
                        flag = true;
                    }
                    // increment index1 for iteration
                    ++index1;
                }
                // if swapping did not occur
                if(flag==false)
                {
                    // break the loop
                    break;
                }
                // set flag back to default value
                flag = false;
            }
        }

        // prints the contents of the integer array
        public static void PrintArray(int[] array)
        {
            // for loop from 0 to n
            for(int item = 0; item<array.Length; item++)
            {
                // if item is not yet n-1
                if(item != array.Length-1)
                {
                    // print data with comma
                    Console.Write(array[item]+", ");
                }
                // if item is n-1
                else
                {
                    // print data only
                    Console.Write(array[item]);
                }
            }
        }
    }
}