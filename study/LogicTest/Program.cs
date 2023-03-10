using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = "{\"DeleteObjects\":[],\"InsertObjects\":[],\"IsSuccess\":1,\"MaintenanceKey\":\"\",\"Message\":\"\",\"Option1\":0,\"UpdateObjects\":[],\"_MaintenanceKey\":\"\",\"_deleteObjects\":[],\"_insertObjects\":[],\"_isSuccess\":1,\"_message\":\"\",\"_option1\":0,\"_updateObjects\":[]}";
            Console.WriteLine(json);

            string test1 = json.Replace("{", "");
            Console.WriteLine(test1);

            string originalString = "The quick brown fox jumps over the lazy dog.";
            string replacementString = "*****";

            string pattern = "quick|brown|fox|lazy"; // use the pipe symbol to separate multiple words

            string modifiedString = Regex.Replace(originalString, pattern, replacementString);

            Console.WriteLine(modifiedString);
            // The ***** ***** ***** jumps over the ***** dog.

            string test2 = Regex.Replace(json, "{|}|\"", "");


            Console.WriteLine("test2 : "+ test2);

            Dictionary<string, string> keyValuePairs = test2.Split(',').ToDictionary(kvp => kvp.Split(':')[0], kvp => kvp.Split(':')[1]);
            Console.WriteLine(keyValuePairs.Keys);

            if (keyValuePairs.ContainsKey("IsSuccess"))
            {
                Console.WriteLine(">....................result : " + keyValuePairs["IsSuccess"]);
                Console.WriteLine(".....Type : {0}", keyValuePairs["IsSuccess"].GetType() );
            }
        }
    }
}
