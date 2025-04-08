using System.IO;
using System.Text.Json;

namespace Modul7_Kelompok3
{
    class DataMahasiswa103022300006
    {
        public class Nama
        {
            public Address address { get; set; }
            public string depan { get; set; }
            public string belakang { get; set; }
            public string gender { get; set; }
            public long age { get; set; }

            public List<mataKkuliah> mata_kuliah { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class mataKkuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON()
        {
            string path = "jurnal7_1_103022300006.json";
            string JsonSring = File.ReadAllText(path);

            Nama nama = JsonSerializer.Deserialize<Nama>(JsonSring);

            Console.WriteLine($"Nama: {nama.depan} {nama.belakang} | Gender: {nama.gender} | Age: {nama.age}");
            Console.WriteLine($"Address: {nama.address.streetAddress}, {nama.address.city}, {nama.address.state}");
            Console.WriteLine("\nDaftar Mata Kuliah:");

            foreach (var matkul in nama.mata_kuliah)
            {
                Console.WriteLine($"kode matkul {matkul.code}nama matkul: {matkul.name}");
            }
        }
    }
}
