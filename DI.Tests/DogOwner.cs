namespace DI.Tests
{
    public class DogOwner : IAnimalOwner
    {
        /// <summary>
        /// Get owner full name
        /// </summary>
        public string Name
        {
            get { return "John Doe (dog owner)"; }
        }
    }
}
