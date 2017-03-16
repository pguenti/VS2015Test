using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIGlet.Net;

namespace ConsoleApplication1
{
    public class Helper
    {
        public string SaySomething()
        {
            var fig = new Figlet();
            var asciiart = fig.ToAsciiArt("Hello Liebe Freunde");
            return asciiart;
        }

        public string SayGoodbye()
        {
            return "Goodbye...";
        }
    }
}
