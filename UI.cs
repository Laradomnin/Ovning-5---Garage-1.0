using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class UI
    {
        public static string AskForString(string parameter)
        {
            Console.Write($"Ange {parameter}: ");

            return Console.ReadLine();
        }

        public static string AskForString()
        {
            return Console.ReadLine();
        }

        public static string AskForString1(string parameter)
        {
            do
            {
                Console.Write($"Ange {parameter}: ");
                var value = Console.ReadLine();
                var i = 0;
                bool result = int.TryParse(value, out i);
                if (result == false)
                    Console.WriteLine("mata gärna in ett heltal tack!");
                value = Console.ReadLine();
                return value;

            } while (false);

    {

            }
        }   }

}    

/*internal static UI Instance { get; set; }
        public void ShowMenu()
        {
            Console.WriteLine("Vilket fordon vill du parkera? "
                          + "\n1. Car"
                          + "\n2. Bus"
                          + "\n3. Airplane"
                          + "\n4. Boat"
                          + "\n5. Avsluta ");

       
    }
}
*/