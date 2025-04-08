using System;
using System.IO;
using System.Text.Json;

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

public class DataMahasiswa
{
	public string firstname { get; set; }
	public string lastname { get; set; }
	public string gender { get; set; }
	public int age { get; set; }
	public Address address { get; set; }
	public List<Course> courses { get; set; }
	
	public static void ReadJSON()
	{
		string filePath = "jurnal7_1_103022330128.json";
		try
		{
			string jsonString = File.ReadAllText(filePath);
			DataMahasiswa mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);
			Console.WriteLine("=== Data Mahasiswa ===");
			Console.WriteLine($"Nama:{mahasiswa.firstname}{mahasiswa.lastname} ");
			Console.WriteLine($"Gender: {mahasiswa.gender}");
			Console.WriteLine($"Umur: {mahasiswa.age}");
			Console.WriteLine($"Alamat: {mahasiswa.address.streetAddress} {mahasiswa.address.city}{mahasiswa.address.state}");

			Console.WriteLine("\nMata Kuliah: ");
			foreach (var course in mahasiswa.courses)
			{
				Console.WriteLine($" -  {course.code}: {course.name} ");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}

}