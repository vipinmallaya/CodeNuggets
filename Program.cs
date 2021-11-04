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

            IndexAccessing();
            TraditionalAccessing();
        }
        #region StringCreation

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
        #endregion

        #region StringConcatination
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
        #endregion

        #region Linq-FirstOrDefault
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
        #endregion

        #region VariableDeclaration
        static void GoodVariableDeclaration()
        {
            var intVar = default(int); // Declare int with default value - 0 in it;
            var stringVar = string.Empty;

            Console.WriteLine("Defaults values for int - {0} and string {1}", intVar, stringVar);
        }
        static void BadVariableDeclaration()
        {
            var intVar = 0; // Declare int with default value - 0 in it;
            var stringVar = "";

            Console.WriteLine("Defaults values for int - {0} and string {1}", intVar, stringVar);
        }
        #endregion

        #region ConditionalOperator
        static void GoodConditionalOperation(bool condition, int input)
        {
            if (condition)
            {
                Console.WriteLine("Condition is true");
            }

            var result = input == 2;
            Console.WriteLine("Condition Evaluation {0}", result);
        }

        static void BadConditionalOperation(bool condition, int input)
        {
            if (condition == true)
            {
                Console.WriteLine("Condition is true");
            }

            var result = input == 2 ? true : false;

            Console.WriteLine("Condition Evaludation {0}", result);
        }
        #endregion

        #region ObjectCreation
        static void NewObjectCreation()
        {
            List<string> newObject = null;
            //...
            //...
            newObject ??= new List<string>();
        }

        static void TraditionalObjectCreation()
        {
            List<string> newObject = null;
            //...
            //...
            if (newObject == null)
            {
                newObject = new List<string>();
            }
        }
        #endregion


        #region Index Accessing
        static string[] Items = new string[] { "Item1", "Item2", "Item3", "Item4" };
        static void IndexAccessing()
        {
            for (int i = 1; i <= Items.Length; i++)
            {
                Console.Write($"{Items[^i]} ");
            }
            //Output 
            //Item4 Item3 Item2 Item1 
        }

        static void TraditionalAccessing()
        {     
            for (int i = Items.Length - 1; i >= 0; i--)
            {
                Console.Write($"{Items[i]} ");
            } 
            //Output 
            //Item4 Item3 Item2 Item1 
        }
        #endregion



    }
}
