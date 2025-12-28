public static class Mission4_WhenAll
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 4 – Task.WhenAll");

        Task t1 = OperacionAsync("ServicioA", 1200);
        Task t2 = OperacionAsync("ServicioB", 900);
        Task t3 = OperacionAsync("ServicioC", 600);

        await Task.WhenAll(t1, t2, t3);
    }

    private static async Task OperacionAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
