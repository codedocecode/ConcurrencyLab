using System;

public static class Mission1_SequentialCPU
{
    public static void Run()
    {
        Console.WriteLine("Mission 1 – Sequential CPU");

        for (int i = 0; i < 5; i++)
        {
            TrabajoCPU(i);
        }
    }

    private static void TrabajoCPU(int index)
    {
        Console.WriteLine($"Inicio trabajo {index} (Thread {Environment.CurrentManagedThreadId})");

        for (long i = 0; i < 2_000_000_000; i++) { }

        Console.WriteLine($"Fin trabajo {index} (Thread {Environment.CurrentManagedThreadId})");
    }
}
