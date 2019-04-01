using System;

namespace DI
{
    public interface IKernel
    {
        /// <summary>
        /// Register type
        /// </summary>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <typeparam name="TImpl">Implementation type</typeparam>
        void RegisterType<TBase, TImpl>() where TImpl : TBase;

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <typeparam name="TType">Type</typeparam>
        /// <returns>An instance of Type</returns>
        TType Resolve<TType>() where TType : class;

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>An instance of Type</returns>
        object Resolve(Type type);
    }
}
