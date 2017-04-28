using Xamarin.Forms;

namespace XFDataBinding.Views
{
    public partial class INPCPage : ContentPage
    {
        public INPCPage()
        {
            InitializeComponent();

            //由於不是使用 Prism 框架，所以，BindingContext 要用到的 ViewModel，必須要自己來設定，當然，也可以在 Code Behind 端來設定
            //BindingContext = new INPCPageViewModel();
        }
    }
}
