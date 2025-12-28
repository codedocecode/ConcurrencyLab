using System;
using System.Threading.Tasks;

public static class Mission2_ParallelCPU_AsyncIO
{
    public static async Task Run()
    {
        Console.WriteLine(""Mission 2 – Parallel CPU + Async I/O"");

        await Parallel.ForEachAsync(
            new int[] {1,2,3,4,5},
            async (item, ct) =>
            {
                TrabajoCPU(item);
                await Task.Delay(500); // Simula I/O
            }
        );
    }

    private static void TrabajoCPU(int id)
    {
        Console.WriteLine($""Inicio CPU {id} ({Environment.CurrentManagedThreadId})"");
        for (long i=0;i<2_000_000_000;i++) { }
        Console.WriteLine($""Fin CPU {id} ({Environment.CurrentManagedThreadId})"");
    }
}
