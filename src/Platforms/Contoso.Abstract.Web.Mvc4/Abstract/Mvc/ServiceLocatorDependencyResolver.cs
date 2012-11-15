#region License
/*
The MIT License

Copyright (c) 2008 Sky Morey

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion
//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Web.Mvc;
//using System.Abstract;
//namespace Contoso.Abstract.Mvc
//{
//    /// <summary>
//    /// ServiceLocatorDependencyResolver
//    /// </summary>
//    public class ServiceLocatorDependencyResolver : IDependencyResolver
//    {
//        private IServiceLocator _serviceLocator;
//        private IServiceRegistrar _serviceRegistrar;

//        public ServiceLocatorDependencyResolver(IServiceLocator serviceLocator)
//        {
//            if (serviceLocator == null)
//                throw new ArgumentNullException("serviceLocator");
//            ServiceLocator = serviceLocator;
//        }

//        public object GetService(Type serviceType)
//        {
//            return ServiceLocator.Registrar.HasRegistered(serviceType) ? ServiceLocator.Resolve(serviceType) : null;
//        }

//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            return ServiceLocator.ResolveAll(serviceType);
//        }

//        public IServiceLocator ServiceLocator
//        {
//            get { return _serviceLocator; }
//            set
//            {
//                if (value == null)
//                    throw new ArgumentNullException("value");
//                _serviceLocator = value;
//                _serviceRegistrar = value.Registrar;
//            }
//        }
//    }
//}
