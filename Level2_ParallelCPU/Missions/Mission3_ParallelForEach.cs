using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class Mission3_ParallelForEach
{
    public static void Run()
    {
        Console.WriteLine("Mission 3 – Parallel.ForEach");

        var trabajos = new List<int> { 1, 2, 3, 4, 5 };

        Parallel.ForEach(trabajos, i =>
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
