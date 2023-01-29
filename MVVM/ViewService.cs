using SharedLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class ViewServiceRegister : IServiceRegister
    {
        public void RegisterService(IServiceCollection serviceCollection)
        {
            if (serviceCollection.All(x => x.Key != typeof(IViewService)))
            {
                serviceCollection.Add(typeof(IViewService), new ViewService());
            }
        }
    }

    public interface IViewService : IService
    {

    }

    public class ViewService : IViewService
    {
        public void Finish(IServiceCollection services)
        {
        }

        public void Startup(IServiceCollection services)
        {
        }
    }
}
