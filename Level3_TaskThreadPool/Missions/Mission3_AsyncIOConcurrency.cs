using System;
using System.Threading.Tasks;

public static class Mission3_AsyncIOConcurrency
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 3 – Async I/O Concurrency");

        Task t1 = SimularIOAsync("LecturaArchivo", 1500);
        Task t2 = SimularIOAsync("ConsultaBaseDatos", 1000);

        await Task.WhenAll(t1, t2);
    }

    private static async Task SimularIOAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
