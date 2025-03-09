using System;

class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Lock()
    {
        if (currentState == State.Terkunci)
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
        else
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public void Unlock()
    {
        if (currentState == State.Terbuka)
        {
            Console.WriteLine("Pintu sudah tidak terkunci");
        }
        else
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}