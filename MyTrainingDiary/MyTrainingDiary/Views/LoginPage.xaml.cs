using MyTrainingDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTrainingDiary.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTrainingDiary.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage ()
		{
			InitializeComponent ();
            BindingContext = new LoginPageVM(Navigation, new UserRepo(), new UserAuthenticationService(new UserCredentialsRepo()));
        }
    }
}