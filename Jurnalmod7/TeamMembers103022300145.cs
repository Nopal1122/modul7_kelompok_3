using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class TeamMembers103022300145
{
    public class Member
    {
        public string firstName
        {
            get; set;
        }

        public string lastName
        {
            get; set;
        }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    public Member[] members { get; set; }
    public static void ReadJSON()
    {
        string path = "../../../jurnal7_2_103022300145.json";
        string jsonString = File.ReadAllText(path);
        TeamMembers103022300145 tmb = JsonSerializer.Deserialize<TeamMembers103022300145>(jsonString);
        Console.WriteLine("Team Member List:");
        for (int i = 0; i < tmb.members.Length; i++)
        {
            Console.WriteLine($"{tmb.members[i].nim} {tmb.members[i].firstName} {tmb.members[i].lastName} ({tmb.members[i].age} {tmb.members[i].gender}");
        }
    }
}

