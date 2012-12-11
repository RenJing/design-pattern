using Autofac;
using caculator;

namespace zhongtong._ExtensionPoint
{
    public class ZhongTongModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ZhongTongPostageCompany>().As<IPostageCompany>();
        }
    }
}
