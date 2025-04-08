using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json

namespace Modul7_Kelompok3
{
    class DataMahasiswa103022300006
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
            public string gender { get; set; }
            public long age { get; set; }



        }
        public class Address
        {
            public Nama nama { get; set; }
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }



        }
        public class mataKkuliah
        {
            public string code { get; set; }
            public string namaMatkul { get; set; }

        }
        public class Kuliah
        {

            public List<mataKkuliah> mata_kuliah { get; set; }
        }
        public class static void ReadJSON()
        {
            string path = "jurnal7_1_103022300006.json";
            string JsonSring = File.ReadAllText(path);
            Address address = JsonSerializer.Deserialize<Address>(JsonSring);
            Console.WriteLine($"nama {address.nama.depan} {address.nama.belakang} gender {address.nama.gender} age: {address.nama.age}");


        }

    }
}
