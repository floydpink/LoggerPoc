using LoggerPoc.Helper;
using LoggerPoc.Service;
using StructureMap;

namespace LoggerPoc.Bootstrap
{
    public class Bootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(initializer =>
                                         {
                                             initializer.AddRegistry<CommonsRegistry>();

                                             initializer.
                                                 For<IServiceOne>().
                                                 Use<ServiceOne>().
                                                 EnrichWith(s => DynamicProxyHelper.CreateInterfaceProxyWithTargetInterface(typeof(IServiceOne), s));

                                             initializer.
                                                 For<IServiceTwo>().
                                                 Use<ServiceTwo>().
                                                 EnrichWith(s => DynamicProxyHelper.CreateInterfaceProxyWithTargetInterface(typeof(IServiceTwo), s));
                                         });

        }

        public static T GetInstance<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}