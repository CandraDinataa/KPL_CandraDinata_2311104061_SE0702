using System;

class DoorMachine {
    private enum State { Terkunci, Terbuka }
    private State state;

    public DoorMachine() {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu() {
        if (state == State.Terkunci) {
            state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu() {
        if (state == State.Terbuka) {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}

class Program {
    static void Main(string[] args) {
        DoorMachine door = new DoorMachine();
        door.BukaPintu();
        door.KunciPintu();
    }
}