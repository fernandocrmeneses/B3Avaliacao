using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B3.Avaliacao.WebApi.App_Start
{
    public static class DependencyResolver
    {
        private static readonly Dictionary<Type, Type> _dependencies = new Dictionary<Type, Type>();

        // Método para registrar tipos (interface e implementação)
        public static void Register<TInterface, TImplementation>()
        {
            _dependencies[typeof(TInterface)] = typeof(TImplementation);
        }

        // Método para resolver dependências
        public static TInterface Resolve<TInterface>()
        {
            Type implementationType = _dependencies[typeof(TInterface)];
            return (TInterface)Activator.CreateInstance(implementationType);
        }
    }
}