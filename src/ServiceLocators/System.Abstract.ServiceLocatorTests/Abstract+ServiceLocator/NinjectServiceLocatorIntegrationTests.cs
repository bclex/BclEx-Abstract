﻿#region License
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
using System.Abstract;
using System.Abstract.Fakes;
using Xunit;
namespace Contoso.Abstract
{
    public class NinjectServiceLocatorIntegrationTests : ServiceLocatorIntegrationTestsBase
    {
        protected override IServiceLocator CreateServiceLocator()
        {
            return new NinjectServiceLocator();
            //var serviceType = typeof(TestService);
            //var serviceType2 = typeof(TestService2);
            //var kernel = new StandardKernel();
            //kernel.Bind<ITestService>().To<TestService>();
            //kernel.Bind<ITestService>().To<TestService>().Named(serviceType.FullName);
            //kernel.Bind<ITestService>().To<TestService2>().Named(serviceType2.FullName);
            //return new NinjectServiceLocator(kernel);
        }
    }
}
