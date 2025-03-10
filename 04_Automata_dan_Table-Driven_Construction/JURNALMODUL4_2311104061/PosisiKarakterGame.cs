using System;

class PosisiKarakterGame
{
    public enum State { Berdiri, Jongkok, Tengkurap, Terbang }
    private State posisiSaatIni;

    public PosisiKarakterGame()
    {
        posisiSaatIni = State.Berdiri;
        Console.WriteLine("Posisi awal: Berdiri");
    }

    public void UbahPosisi(State posisiBaru)
    {
        Console.WriteLine($"Beralih ke posisi {posisiBaru}");

        if (posisiSaatIni == State.Terbang && posisiBaru == State.Jongkok)
            Console.WriteLine("Posisi landing");

        if (posisiSaatIni == State.Berdiri && posisiBaru == State.Terbang)
            Console.WriteLine("Posisi take off");

        if (posisiSaatIni == State.Berdiri && posisiBaru == State.Tengkurap)
            Console.WriteLine("Posisi istirahat");

        if (posisiSaatIni == State.Tengkurap && posisiBaru == State.Berdiri)
            Console.WriteLine("Posisi standby");

        posisiSaatIni = posisiBaru;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("===== Program Posisi Karakter Game =====");
        PosisiKarakterGame karakter = new PosisiKarakterGame();
        karakter.UbahPosisi(PosisiKarakterGame.State.Terbang);
        karakter.UbahPosisi(PosisiKarakterGame.State.Jongkok);
        karakter.UbahPosisi(PosisiKarakterGame.State.Berdiri);
        karakter.UbahPosisi(PosisiKarakterGame.State.Tengkurap);
    }
}
