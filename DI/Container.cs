namespace DI
{
    public abstract class Container
    {
        private object _lock = new object();
        private IKernel _kernel;

        /// <summary>
        /// Get current kernel
        /// </summary>
        public IKernel Kernel
        {
            get
            {
                lock (_lock)
                    if (_kernel == null)
                        _kernel = CreateKernel();

                return _kernel;
            }
        }

        /// <summary>
        /// Create kernel
        /// </summary>
        /// <returns>An insance of the ker</returns>
        protected virtual IKernel CreateKernel()
        {
            return new Kernel();
        }

        /// <summary>
        /// Initialize container
        /// </summary>
        public virtual void Init()
        {
            Register(Kernel);
        }

        /// <summary>
        /// Register types
        /// </summary>
        /// <param name="kernel">Kernel</param>
        public abstract void Register(IKernel kernel);
    }
}
