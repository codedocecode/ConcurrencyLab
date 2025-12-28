using System;
using System.Diagnostics;
using System.Threading.Tasks;

public static class Mission4_ParallelVsSequential
{
    public static void Run()
    {
        Console.WriteLine("Mission 4 – Parallel vs Sequential");

        var sw = Stopwatch.StartNew();

        for (int i = 0; i < 5; i++)
        {
            TrabajoCPU(i);
        }

        sw.Stop();
        Console.WriteLine($"Sequential time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();

        Parallel.For(0, 5, i =>
        {
            TrabajoCPU(i);
        });

        sw.Stop();
        Console.WriteLine($"Parallel time: {sw.ElapsedMilliseconds} ms");
    }

    private static void TrabajoCPU(int index)
    {
        for (long i = 0; i < 2_000_000_000; i++) { }
    }
}
