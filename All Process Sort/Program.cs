using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var myProcess = from proc in Process.GetProcesses(".")
                        // Сортировка по приоритету
                        orderby proc.BasePriority select proc;
        Console.WriteLine("\n*** Текущие процессы ***\n");
        foreach (var p in myProcess)
            Console.WriteLine("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);
    }
}