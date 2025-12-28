using System;
using System.Threading.Tasks;

public static class Mission2_ParallelFor
{
    public static void Run()
    {
        Console.WriteLine("Mission 2 – Parallel.For");

        Parallel.For(0, 5, i =>
        {
            TrabajoCPU(i);
        });
    }

    private static void TrabajoCPU(int index)
    {
        Console.WriteLine($"Inicio trabajo {index} (Thread {Environment.CurrentManagedThreadId})");

        for (long i = 0; i < 2_000_000_000; i++) { }

        Console.WriteLine($"Fin trabajo {index} (Thread {Environment.CurrentManagedThreadId})");
    }
}
