using System;
using Castle.DynamicProxy;
using LoggerPoc.Bootstrap;
using LoggerPoc.Logging;
using log4net;

namespace LoggerPoc.Helper
{
    public class DynamicProxyHelper
    {
        public static object CreateInterfaceProxyWithTargetInterface(Type interfaceType, object concreteObject)
        {
            var proxyGenerator = new ProxyGenerator();
            var result = proxyGenerator.CreateInterfaceProxyWithTargetInterface(interfaceType,
                concreteObject,
                new IInterceptor[] { new LogInterceptor(LogManager.GetLogger(concreteObject.GetType())) });

            return result;
        }
    }
}