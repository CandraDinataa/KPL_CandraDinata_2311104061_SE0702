using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }

    public static bool ValidateUsername(string username)
    {
        return !string.IsNullOrWhiteSpace(username) &&
               username.Length >= 5 && username.Length <= 20 &&
               Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
    }

    public static bool ValidatePassword(string password, string username)
    {
        return password.Length >= 8 &&
               password.Length <= 20 &&
               Regex.IsMatch(password, @"[!@#$%^&*]") &&
               !password.ToLower().Contains(username.ToLower());
    }

    public static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(hashedBytes);
    }
}
