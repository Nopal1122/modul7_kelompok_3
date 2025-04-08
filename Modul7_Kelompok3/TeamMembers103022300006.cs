using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static Modul7_Kelompok3.DataMahasiswa103022300006;


namespace Modul7_Kelompok3
{
    class TeamMembers103022300006
    {

        public class members
        {
            public string depan { get; set; }
            public string belakang { get; set; }
            public string gender { get; set; }
            public long age { get; set; }
            public string nim { get; set; }


        }
        public class Members
        {
            public List<members> members { get; set; }


        }

        public static void ReadJSON()
        {
            string path = "jurnal7_2_103022300006.json";
            string JsonSring = File.ReadAllText(path);

            Members mem = JsonSerializer.Deserialize<Members>(JsonSring);

            foreach (var members in )
            {
                Console.WriteLine($"kode matkul {matkul.code}nama matkul: {matkul.name}");
            }
        }
    }
}

    }
}
