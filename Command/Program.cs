using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var page = new ProfilePage();

            page.ShowPage();
            Console.WriteLine($"Clipboard: {page.ActiveInput.Text}");

            page.ButtonCopy.Execute();
            Console.WriteLine($"Clipboard: {page.ActiveInput.Text}");

            page.ButtonCut.Execute();
            Console.WriteLine($"Clipboard: {page.ActiveInput.Text}");

            page.ButtonReplace.Execute();
            Console.WriteLine($"Clipboard: {page.ActiveInput.Text}");

            page.Undo();
            Console.WriteLine($"Clipboard: {page.ActiveInput.Text}");

            Console.ReadKey();
        }
    }
}
