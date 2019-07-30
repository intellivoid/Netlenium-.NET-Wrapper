using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Session");
            var browser = new Intellivoid.Netlenium.Client();
            browser.Start();

            Console.WriteLine("Navigating to Google");
            browser.LoadUrl("https://google.com/");

            Console.WriteLine("Typing into search box");
            browser.GetElement(Intellivoid.Netlenium.By.Name, "q").SendKeys("Netlenium");

            Console.WriteLine("Searching for results");
            browser.GetElement(Intellivoid.Netlenium.By.Name, "q").Submit();

            foreach(Intellivoid.Netlenium.Element element in browser.GetElements(Intellivoid.Netlenium.By.ClassName, "g"))
            {
                Console.WriteLine(element.InnerText);
                Console.WriteLine();
            }

            Console.WriteLine("Closing session");
            browser.Stop();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
