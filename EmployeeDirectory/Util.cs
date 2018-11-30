using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    static class Util
    {
        public static int AskForInt(string prompt, string errorPrompt = "Felaktigt format, bara siffror får användas.")
        {
            int answer;
            bool success;
            do  // Repetera ...
            {
                string input = AskForString(prompt);

                #region try-catch
                // alternativ lösning
                //try
                //{
                //    salary = Convert.ToInt32(salaryString);
                //} catch (Exception e) {
                //    Console.WriteLine(e.Message + "\nFelaktigt format, lönen sätts till 0 kr");
                //}
                #endregion

                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine(errorPrompt);
                }
            } while (!success);  // ... så länge som vi inte har lyckats parsa strängen
            return answer;
        }

        public static string AskForString(string prompt)
        {
            Console.Write(prompt);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
