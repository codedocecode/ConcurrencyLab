using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class Mission4_RealisticPipeline
{
    public static async Task Run()
    {
        Console.WriteLine(""Mission 4 – Realistic Pipeline"");

        var items = new List<int>{1,2,3,4,5};

        await Parallel.ForEachAsync(items, async (item, ct) =>
        {
            // CPU paralelo
            for (long i=0;i<1_000_000_000;i++) { }
            // I/O simulado
            await Task.Delay(300);
            Console.WriteLine($""Item {item} procesado ({Environment.CurrentManagedThreadId})"");
        });
    }
}
