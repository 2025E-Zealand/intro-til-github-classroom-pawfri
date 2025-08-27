using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        public string Navn { get; set; }
        public int Antal { get; set; }
        public bool ErDetSandt { get; set; }

        public Demo(string navn, int antal, bool erDetSandt)
        {
            Navn = navn;
            Antal = antal;
            ErDetSandt = erDetSandt;
        }
    }
     
}
