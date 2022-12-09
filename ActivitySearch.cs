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
    public class ActivitySearch
    {
        public void get_activities()
        {
            // Creating new dictionary
            Dictionary<double, double> activityList = new Dictionary<double,double>();
            activityList.Add(13.40,14.30);
            activityList.Add(6.30,8.00);
            activityList.Add(7.00,8.30);
            activityList.Add(8.00,9.30);
            activityList.Add(10.00,11.30);
            activityList.Add(13.00,14.30);
            activityList.Add(9.00,9.30);
            activityList.Add(8.01,9.00);
            activityList.Add(9.30,10.00);
            activityList.Add(12.00,13.00);
            activityList.Add(14.50,16.50);

            // Show all activities in unordered form first.
            Console.WriteLine("List of activities not in order:\n");
            PrintActivities(activityList);

            // Sort items in activityList by Value in ascending order.
            // LINQ form of sorting.
            var activities = from entry in activityList orderby entry.Value ascending select entry; 
            
            // Show all activities in ordered form.
            Console.WriteLine("List of activities in order:\n");
            foreach(var activity in activities)
            {
                Console.WriteLine(activity.Key+"->"+activity.Value);
            }
            Console.WriteLine();
            
            // previous_end stores the finish time of last approved activity.
            double previous_end = 0.00;

            // Print approved activities.
            Console.WriteLine("New set of picked activities:\n");
            foreach(var activity in activities)
            {
                // If the early time of activity is greater than the finish time of last activity.
                if(activity.Key>=previous_end)
                {
                    // Print the approved activity.
                    Console.WriteLine(activity.Key+"->"+activity.Value);
                    // Set the current activity's finish time as the previous activity.
                    previous_end = activity.Value;
                }
            }
            Console.WriteLine();
        }

        // PrintActivities prints the dictionary collection items
        public static void PrintActivities(Dictionary<double, double> activityList)
        {
            foreach(var activity in activityList)
            {
                Console.WriteLine(activity.Key+"->"+activity.Value);
            }
            Console.WriteLine();
        }
    }
}