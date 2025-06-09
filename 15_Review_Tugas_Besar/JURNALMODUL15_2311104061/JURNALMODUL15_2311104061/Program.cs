using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static string filePath = @"C:\Users\Candra Dinata\source\repos\JURNALMODUL15_2311104061\JURNALMODUL15_2311104061\users.json";
    static List<User> users = new();

    static void Main()
    {
        LoadUsers();

        while (true)
        {
            Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
            Console.Write("Pilih opsi: ");
            string opsi = Console.ReadLine();

            if (opsi == "1") Register();
            else if (opsi == "2") Login();
            else if (opsi == "3") break;
            else Console.WriteLine("Opsi tidak valid.");
        }
    }

    static void Register()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        if (!User.ValidateUsername(username))
        {
            Console.WriteLine("Username harus 5-20 karakter dan hanya huruf/angka.");
            return;
        }

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        if (!User.ValidatePassword(password, username))
        {
            Console.WriteLine("Password minimal 8 karakter, mengandung simbol (!@#$%^&*), dan tidak boleh mengandung username.");
            return;
        }

        string hashedPassword = User.HashPassword(password);
        users.Add(new User { Username = username, PasswordHash = hashedPassword });
        SaveUsers();

        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        string hashedPassword = User.HashPassword(password);
        foreach (var user in users)
        {
            if (user.Username == username && user.PasswordHash == hashedPassword)
            {
                Console.WriteLine($"\nLogin berhasil! Selamat datang, {username}.");
                ShowSayaTubeFeatures(username);
                return;
            }
        }

        Console.WriteLine("Login gagal. Username atau password salah.");
    }

    static void ShowSayaTubeFeatures(string username)
    {
        SayaTubeUser userObj = new SayaTubeUser(username);

        for (int i = 1; i <= 10; i++)
        {
            var video = new SayaTubeVideo($"Video belajar C# part {i}");
            video.IncreasePlayCount(1000 * i);
            userObj.AddVideo(video);
        }

        userObj.PrintAllVideoPlaycount();
    }

    static void LoadUsers()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }

    static void SaveUsers()
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
