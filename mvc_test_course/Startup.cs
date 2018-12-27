using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_test_course.Startup))]
namespace mvc_test_course
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
