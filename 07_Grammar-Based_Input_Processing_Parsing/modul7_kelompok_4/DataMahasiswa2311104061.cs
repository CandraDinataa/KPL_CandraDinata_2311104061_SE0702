using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104061
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
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
        public List<Course> courses { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "jurnal7_1_2311104061.json";
        string jsonString = File.ReadAllText(filePath);

        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine($"Nama: {mhs.firstName} {mhs.lastName}");
        Console.WriteLine($"Jenis Kelamin: {mhs.gender}");
        Console.WriteLine($"Umur: {mhs.age}");
        Console.WriteLine($"Alamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
        Console.WriteLine("\nMata Kuliah yang Diambil:");

        int i = 1;
        foreach (var course in mhs.courses)
        {
            Console.WriteLine($"MK {i++}: {course.code} - {course.name}");
        }

        Console.ReadLine();
    }
}