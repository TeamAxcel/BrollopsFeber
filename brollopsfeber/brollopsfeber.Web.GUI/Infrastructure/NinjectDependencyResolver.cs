using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using brollopsfeber.Domain.Entites;
using brollopsfeber.Domain.Abstract;
using brollopsfeber.Domain.Concrete;

namespace brollopsfeber.Web.GUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;

            Mock<IExhibitorRepository> mock = new Mock<IExhibitorRepository>();
            mock.Setup(m => m.Exhibitors).Returns(new List<Exhibitor>
            {
                new Exhibitor() { Name = "Jonas Strandberg" },
                new Exhibitor() { Name = "Erik Falkberg" }
            });

            _kernel.Bind<IExhibitorRepository>().ToConstant(mock.Object);
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}