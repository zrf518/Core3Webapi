using Autofac;
using System.Reflection;
namespace CeCheng.SmartScenicSpot.Webapi.AutoFac
{
    /// <summary>
    /// Autofac容器注入
    /// </summary>
    public  static class AutoFacContainerInit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public static void DependencyInJectionByAutoFact(this ContainerBuilder builder) {
            var assembly = Assembly.Load("CeCheng.SmartScenicSpot.Services");
            //.Where(c=>c.Name.Contains(""))
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
        }
    }
}
