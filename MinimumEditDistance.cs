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
    public class MinimumEditDistance
    {
        public int min_edit_dist(string str, string str2)
        {
            // length of first string stored
            int strLen = str.Length;
            // length of second string stored
            int str2Len = str2.Length;
            
            // lengths in new 2D array have +1 to give space for the root = 0.
            // the root should not have any comparison.
            int[,] med = new int[strLen+1,str2Len+1];

            // Set 1st row with each items as 0, 1, 2, 3,..., strLen+1.
            for(int i = 0; i<strLen+1; i++)
            {
                med[i,0] = i;
            }

            // Set 1st column with each items as 0, 1, 2, 3,..., str2Len+1.
            for(int i = 0; i<str2Len+1; i++)
            {
                med[0,i] = i;
            }

            // similar is 0 if compared characters are equal.
            // else, similar is set to 1.
            int similar = 0;

            // Minimum Edit Distance
            for (int i = 1; i<strLen+1; i++)
            {
                for(int j = 1; j<str2Len+1; j++)
                {
                    // If an index in first string is equal to an index in the second string.
                    if(str[i-1]==str2[j-1])
                    {
                        similar = 0;
                    }
                    // If an index in first string is not equal to an index in the second string.
                    else
                    {
                        similar = 1;
                    }

                    // get the minimum of three cases
                    int minimum = Math.Min(med[i-1,j]+1, med[i,j-1]+1);
                    med[i,j] = Math.Min(minimum, med[i-1,j-1]+similar);
                }
            }

            // Output the minimum edit distance result.
            return med[strLen,str2Len];
        }
    }
}