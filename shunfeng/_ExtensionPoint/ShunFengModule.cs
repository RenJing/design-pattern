using Autofac;
using caculator;

namespace shunfeng._ExtensionPoint
{
    public class ShunFengModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShunFengPostageCompany>().As<IPostageCompany>();
        }
    }
}
