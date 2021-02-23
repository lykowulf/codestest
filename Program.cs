using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codestest
{
    class Program 
    {
        static void Main(string[] args)
        {
            //user input (Prices)
            Console.WriteLine("How much is book one?");
            string bookInit = Console.ReadLine();
            decimal bookPrice = IsNumOnly(bookInit) ? decimal.Parse(bookInit) : 0;

            Console.WriteLine("How much is book two?");
            string book2Init = Console.ReadLine();
            decimal bookPrice2 = IsNumOnly(book2Init) ? decimal.Parse(book2Init) : 0;


            Console.WriteLine("How much is the music CD?");
            string musicCDInit = Console.ReadLine();
            decimal musicCDPrice = IsNumOnly(musicCDInit) ? decimal.Parse(musicCDInit) : 0;

            Console.WriteLine("How much is the Chocolatebar?");
            string chocolateBarInit = Console.ReadLine();
            decimal chocolateBarPrice = IsNumOnly(chocolateBarInit) ? decimal.Parse(chocolateBarInit) : 0;


            //sales taxs entered by user
            Console.WriteLine("Enter in 0.10% for sales tax.");
            string basicSalesTaxInit = Console.ReadLine();
            decimal salesTaxAmount = IsNumOnly(basicSalesTaxInit) ? decimal.Parse(basicSalesTaxInit) : 0;

            //calculations based on information giving.          
            decimal salesTax = 1.50m;
            decimal bookTotal = bookPrice + bookPrice2;
            decimal musicCDTotal = Math.Round(musicCDPrice * salesTaxAmount, 2) + musicCDPrice;
            decimal overAllTotal = (bookTotal + musicCDPrice + chocolateBarPrice + salesTax);

            //output
            Console.ReadLine();
            Console.WriteLine("Book:" + " " + bookTotal + " " + "(2 @ 12.49)");
            Console.WriteLine("Music CD:" + " " + musicCDTotal);
            Console.WriteLine("Chocolate bar:" + " " + chocolateBarPrice);
            Console.WriteLine("Sales Taxes:" + " " + salesTax);
            Console.WriteLine("Total:" + " " + overAllTotal);
            Console.ReadLine();
        }

        static bool IsNumOnly(string userInput)
        {
            //checks to see if there is any spaces entered in by the user.
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            //checks to see if numbers entered by user matches if so returns results if not returns false. 
            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$");
            Match m = r.Match(userInput);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
