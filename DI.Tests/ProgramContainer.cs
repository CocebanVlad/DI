namespace DI.Tests
{
    public class ProgramContainer : Container
    {
        /// <summary>
        /// Register types
        /// </summary>
        /// <param name="kernel">Kernel</param>
        public override void Register(IKernel kernel)
        {
            kernel.RegisterType<IAnimal, Dog>();
            kernel.RegisterType<IAnimalOwner, SmallDogOwner>();
        }
    }
}
