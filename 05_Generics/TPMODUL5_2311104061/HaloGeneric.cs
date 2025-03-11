using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
 HEAD
        halo.SapaUser("can");
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> data = new DataGeneric<string>("2311104061"); 
        data.PrintData();
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> data = new DataGeneric<string>("2311104061"); 
        data.PrintData();
    }
}
