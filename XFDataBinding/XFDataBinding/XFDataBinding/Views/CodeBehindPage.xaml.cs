using Xamarin.Forms;
using XFDataBinding.ViewModels;

namespace XFDataBinding.Views
{
    public partial class CodeBehindPage : ContentPage
    {
        public CodeBehindPage()
        {
            InitializeComponent();

            btn登入.Clicked += (s, e) =>
            {
                MyLabel.Text = MyEntry.Text;
            };
        }
    }
}
