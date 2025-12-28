public static class Mission1_SequentialAwait
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 1 – Sequential Await");

        await OperacionAsync("CargaConfiguracion", 1000);
        await OperacionAsync("LecturaDatos", 800);
    }

    private static async Task OperacionAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
