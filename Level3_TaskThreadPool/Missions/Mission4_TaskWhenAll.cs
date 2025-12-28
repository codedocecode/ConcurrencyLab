using System;
using System.Threading.Tasks;

public static class Mission4_TaskWhenAll
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 4 – Task.WhenAll behavior");

        Task t1 = TrabajoAsync("ServicioX", 1000);
        Task t2 = TrabajoAsync("ServicioY", 700);

        await Task.WhenAll(t1, t2);

        Console.WriteLine("All tasks completed");
    }

    private static async Task TrabajoAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
