using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class DataMahasiswa103022300145
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Courses[] courses { get; set; }
    }

    public static void ReadJSON()
    {
        string path = "jurnal7_1_103022300145.json";
        string jsonString = File.ReadAllText(path);
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        Console.WriteLine($"Name : {mhs.firstName} {mhs.lastName} \nGender : {mhs.gender} \nAge : {mhs.age} \nAddress : \nstreetAddress : {mhs.address.streetAddress} \ncity : {mhs.address.city} \nstate : {mhs.address.state}");
        for (int i = 0; i < mhs.courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {mhs.courses[i].code} - {mhs.courses[i].name}");
        }
    }
}
