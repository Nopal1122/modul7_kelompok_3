using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json

namespace Modul7_Kelompok3
{
    class TeamMembers_103022330128
    {
        public List<Member> members
        {
            get; set;
        }

        public class Member
        {
            public string nim { get; set; }
            public string first { get; set; }
            public string last { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
        }

        public static void ReadJSON()
        {
            string path = "jurnal7_2_103022330128";
            string JsonSring = File.ReadAllText(path);
            Console.WriteLine($"{member.nim}")
        }
    }
}
