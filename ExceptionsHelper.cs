using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class ExceptionsHelper
    {
        public void TestException(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"'{nameof(input)}' Får ej vara null eller tomt .", nameof(input));
            }



        }


    }

}

/*internal class Exempel
{
    static void Main(string[] args)
    {
        try
        {
            Admin ad = new();
            ad.TestException(null);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (Exception)
        {

        }
        finally
        {
*/

        