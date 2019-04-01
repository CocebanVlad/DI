using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public class Kernel : IKernel
    {
        private readonly Dictionary<Type, Type> _map = new Dictionary<Type, Type>();

        /// <summary>
        /// Register type
        /// </summary>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <typeparam name="TImpl">Implementation type</typeparam>
        public void RegisterType<TBase, TImpl>() where TImpl : TBase
        {
            _map[typeof(TBase)] = typeof(TImpl);
        }

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <typeparam name="TType">Type</typeparam>
        /// <returns>An instance of Type</returns>
        public TType Resolve<TType>() where TType : class
        {
            return (TType)Resolve(typeof(TType));
        }

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>An instance of Type</returns>
        public object Resolve(Type type)
        {
            if (_map.ContainsKey(type))
                return Resolve(_map[type]);
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            if (type.IsInterface)
                throw new KernelException("Interface \"" + type.Name + "\" cannot be resolved");
            if (type.IsAbstract)
                throw new KernelException("Abstract class \"" + type.Name + "\" cannot be resolved");

            var ctors =
                type.GetConstructors();

            return ctors.Length == 0
                ? Activator.CreateInstance(type)
                : Activator.CreateInstance(type, ctors[0].GetParameters().Select(x => Resolve(x.ParameterType)).ToArray());
        }
    }
}
