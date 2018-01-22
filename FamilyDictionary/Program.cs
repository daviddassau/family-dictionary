using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Adds a new Dictionary called myFamily
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            // Adds to the myFamily Dictionary
            // Adds a Key and then two Key/Value pairs to that initial Key
            myFamily.Add("wife", new Dictionary<string, string>(){
                {"name", "Lindsay"},
                {"age", "33"}
            });
            myFamily.Add("son", new Dictionary<string, string>(){
                {"name", "Charlie"},
                {"age", "3"}
            });
            myFamily.Add("daughter", new Dictionary<string, string>(){
                {"name", "Erin"},
                {"age", "17 months"}
            });

            // Loop over the Key/Value pairs in the myFamily Dictionary
            foreach (var item in myFamily)
            {
                var member = item.Key; // Assigns the original Key of "wife" to the variable member
                var famMemDetails = item.Value; // Assigns the values in the Dictionary to the variable sibling
                var famStr = ""; // An empty variable to hold the final string result

                // Loop over the nested Key/Value pairs
                foreach (var details in famMemDetails) 
                {
                    // Checks to see if the nested Key has a string value of "name"
                    // If it does, it assigns the first part of the necessary output to to the famStr variable
                    if (details.Key == "name")
                        famStr = details.Value + " is my " + member;

                    // Checks to see if the nested Key has a string value of "age"
                    // If it does, it assigns the second part of the necessary output to to the famStr variable
                    if (details.Key == "age")
                        famStr += " and is " + details.Value + " years old";
                }

                Console.WriteLine(famStr); // Final console output
            }

            Console.ReadLine();

        }
    }
}
