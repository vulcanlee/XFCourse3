using Prism.Unity;
using XFDataBinding.Views;
using Xamarin.Forms;

namespace XFDataBinding
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<CodeBehindPage>();
            Container.RegisterTypeForNavigation<PrismPage>();
            Container.RegisterTypeForNavigation<FodyPage>();
            Container.RegisterTypeForNavigation<INPCPage>();
        }
    }
}
