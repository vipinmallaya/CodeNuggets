using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CodeNuggets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GoodVariableDeclaration();
            BadVariableDeclaration();
        }

        static void BadStringOperation()
        {
            var sampleString = string.Empty;
            var names = new List<string>()
            { "Name1", "Name2",  "Name3", "Name4" };

            for (int i = 0; i < names.Count; i++)
            {
                sampleString = sampleString + names[i];
            }

            Console.WriteLine("Joined String {0}", sampleString);
        }

        static void GoodStringOperation()
        {
            var sampleString = new StringBuilder();
            var names = new List<string>()
            { "Name1", "Name2",  "Name3", "Name4" };
            for (int i = 0; i < names.Count; i++)
            {
                sampleString.Append(names[i]);
            }

            Console.WriteLine("Joined String {0}", sampleString.ToString());
        }

        static void BadStringConcatinationOperation()
        {
            var inputString = "Test1";
            var outPutString = inputString + "!" + ";";

            Console.WriteLine("Joined String {0}", outPutString);
        }

        static void GoodStringConCatinationOperation()
        {
            var inputString = "Test1";
            var outPutString = $"{inputString}!;";

            Console.WriteLine("Joined String {0}", outPutString);
        }

        static List<KeyValuePair<string, string>> NameAndGrade = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string,string>("Name1","A"),
            new KeyValuePair<string,string>("Name2","B"),
            new KeyValuePair<string,string>("Name3","C"),
        };

        static void GoodWorkingWithListForOneItem()
        { 
            var nameWithGradeC = NameAndGrade.FirstOrDefault(item => item.Value == "C");
            Console.WriteLine("Name With Grade C {0}", nameWithGradeC.Key);
        }

        static void BadWorkingWithListForOneItem()
        { 
            var result = NameAndGrade.Where(item => item.Value == "C");
            var nameWithGradeC = result.FirstOrDefault();
            Console.WriteLine("Name With Grade C {0}", nameWithGradeC.Key);
        }

        static void GoodVariableDeclaration()
        {
            var intVar = default(int); // Declare int with default value - 0 in it;
            var stringVar = string.Empty; 

            Console.WriteLine("Defaults values for int - {0} and string {1}", intVar,stringVar);
        }
        static void BadVariableDeclaration()
        {
            var intVar = 0; // Declare int with default value - 0 in it;
            var stringVar = "";

            Console.WriteLine("Defaults values for int - {0} and string {1}", intVar, stringVar);
        }
    }
}
