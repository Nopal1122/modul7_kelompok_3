using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_Kelompok3
{
    public class DataMahasiswa103022300095
    {
        public class Address
        {
            [JsonPropertyName("streetAddress")]
            public string StreetAddress { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }
        }

        public class Course
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("gender")]
            public string Gender { get; set; }

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("address")]
            public Address Address { get; set; }

            [JsonPropertyName("courses")]
            public List<Course> Courses { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022300095.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama: {mhs.FirstName} {mhs.LastName}");
            Console.WriteLine($"Jenis Kelamin: {mhs.Gender}");
            Console.WriteLine($"Umur: {mhs.Age}");
            Console.WriteLine($"Alamat: {mhs.Address.StreetAddress}, {mhs.Address.City}, {mhs.Address.State}");
            Console.WriteLine("Mata Kuliah:");
            foreach (var course in mhs.Courses)
            {
                Console.WriteLine($"- {course.Code} : {course.Name}");
            }
        }
    }
}