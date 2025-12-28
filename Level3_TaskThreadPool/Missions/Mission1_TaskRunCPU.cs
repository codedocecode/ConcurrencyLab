using System;
using System.Threading.Tasks;

public static class Mission1_TaskRunCPU
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 1 – Task.Run (CPU-bound)");

        Task t1 = Task.Run(() => TrabajoCPU(1));
        Task t2 = Task.Run(() => TrabajoCPU(2));

        await Task.WhenAll(t1, t2);
    }

    private static void TrabajoCPU(int id)
    {
        Console.WriteLine($"Inicio trabajo CPU {id} (Thread {Environment.CurrentManagedThreadId})");

        for (long i = 0; i < 2_000_000_000; i++) { }

        Console.WriteLine($"Fin trabajo CPU {id} (Thread {Environment.CurrentManagedThreadId})");
    }
}
