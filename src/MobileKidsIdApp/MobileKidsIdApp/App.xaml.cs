using System.Threading.Tasks;
using MobileKidsIdApp.Services;
using MobileKidsIdApp.ViewModels;
using MobileKidsIdApp.Views;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileKidsIdApp
{
    public partial class App : ApplicationBase
    {
        public App() => InitializeComponent();

        protected override void InitializeContainer()
        {
#if DEBUG
            Container.AddExtension(new Diagnostic());
#endif

            Container.RegisterSingleton<AuthenticationService>();
            Container.RegisterSingleton<FamilyRepository>();
        }

        protected override Task<Page> CreateMainPage()
            => CreatePage<LoginPage, LoginViewModel>();

        // TODO: use onstart/pause/resume to add more security around auth
    }
}
