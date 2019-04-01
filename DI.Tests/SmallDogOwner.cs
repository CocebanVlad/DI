namespace DI.Tests
{
    public class SmallDogOwner : IAnimalOwner
    {
        /// <summary>
        /// Get owner full name
        /// </summary>
        public string Name
        {
            get { return "Maria Theresa (small dog owner)"; }
        }
    }
}
