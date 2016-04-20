using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
What are your nouns in the above requirements? You will need to declare variables for them. Remember, you can name these variables anything you wish but it helps to name them as they relate to the problem. Some obvious suggestions are age, classification, and rate. “Child”, “Teen”, 1.0, 1.5, 13, 65, etc. are values placed in variables; they are not variables in and of themselves.
Age should first be read into a string variable so it can be tested for an empty string ("").
Use the following data types:
Integer for age
Floating point for rate Multiplier
String for Classification
Input: Read in the user’s input using Python's input statement or C#'s Console.ReadLine() method.
Process: Use the if-else-if statements to set values of classification and rate variables.
Output: Use Python's print statement or C#'s Console.WriteLine() to write results stored in those two variables to the Console. All of your output statements should be after your if-else-if statement ends. You should not put output statements in your condition statement blocks, only a single set of output statements after your if statement processes have set associated variables.
*/

namespace InsuranceRates_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int     age;
            float   rate;
            String classification;

            // Input Person's Age as an integer
            
            Console.Write("Please enter person's age: ");
            string inputText = Console.ReadLine();
            if (inputText != "");
            {

            age = int.Parse(inputText);

            // Given Age assign classification and rate

            if (age <= 12)
            {
                classification = "Child";
                rate = 1.0f;

            }    
            else if (age <= 18)
            {
                classification = "Teen";
                rate = 1.5f;
            }
            else if (age <= 65)
            {
                classification =  "Adult"; 
                rate = 1.7f;
            }
            else // 66 and above
            {
                classification = "Senior";
                rate = 2f;
            }

            //   Outputs:
            Console.WriteLine("Person's Age: " + age.ToString());
            Console.WriteLine("Classification: " + classification);
            Console.WriteLine("Rate Multiplier: " + rate.ToString());

            Console.ReadLine();

            }
        }
    }
}
