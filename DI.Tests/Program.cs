namespace DI.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ProgramContainer();
            container.Init();

            var animal = container.Kernel.Resolve<IAnimal>();
            animal.MakeSound();
        }
    }
}
