using System;
using System.Threading.Tasks;

public static class Mission3_TaskWhenAllMixed
{
    public static async Task Run()
    {
        Console.WriteLine(""Mission 3 – Task.WhenAll Mixed"");

        Task t1 = Task.Run(() => TrabajoCPU(1));
        Task t2 = Task.Run(() => TrabajoCPU(2));
        Task t3 = SimularIOAsync(""ServicioX"", 1000);
        Task t4 = SimularIOAsync(""ServicioY"", 800);

        await Task.WhenAll(t1,t2,t3,t4);
    }

    private static void TrabajoCPU(int id)
    {
        Console.WriteLine($""Inicio CPU {id} ({Environment.CurrentManagedThreadId})"");
        for (long i=0;i<2_000_000_000;i++) { }
        Console.WriteLine($""Fin CPU {id} ({Environment.CurrentManagedThreadId})"");
    }

    private static async Task SimularIOAsync(string nombre, int delay)
    {
        Console.WriteLine($""Inicio {nombre} ({Environment.CurrentManagedThreadId})"");
        await Task.Delay(delay);
        Console.WriteLine($""Fin {nombre} ({Environment.CurrentManagedThreadId})"");
    }
}
