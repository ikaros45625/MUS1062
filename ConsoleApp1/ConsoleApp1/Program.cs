using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("CWBEQ.xml");
            
        }
    }
}
