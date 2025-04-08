using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json

namespace Modul7_Kelompok3
{
    class DataMahasiswa_103022330128
    {
        public class Nama
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
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
        public class Courses
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
            string path = "jurnal7_1_103022330128.json";
            string JsonSring = File.ReadAllText(path);
            Address address = JsonSerializer.Deserialize<Address>(JsonSring);
            Console.WriteLine($"nama {address.nama.firstName} {address.nama.lastName} gender {address.nama.gender} age: {address.nama.age}");


        }

    }

    
}