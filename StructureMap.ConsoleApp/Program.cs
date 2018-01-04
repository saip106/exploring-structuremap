namespace StructureMap.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrapper.Bootstrap();
            var consoleApplication = container.GetInstance<ConsoleApplication>();
            consoleApplication.Run();
        }
    }
}
