using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TeamMembers2311104061
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class MembersData
    {
        public List<Member> members { get; set; }
    }

    public static void ReadJSON()
    {
        try
        {
            string filePath = "jurnal7_2_2311104061.json";
            string jsonString = File.ReadAllText(filePath);

            MembersData data = JsonSerializer.Deserialize<MembersData>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var m in data.members)
            {
                Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal : " + ex.Message);
        }

        Console.ReadLine();
    }
}