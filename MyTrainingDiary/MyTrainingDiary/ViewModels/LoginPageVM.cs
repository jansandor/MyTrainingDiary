using Xamarin.Forms;
using System;
using MyTrainingDiary.DAL;
using System.Linq;
using System.Windows.Input;
using MyTrainingDiary.Views;
using System.Threading.Tasks;
using MyTrainingDiary.DAL.Interfaces;
using MyTrainingDiary.DAL.Models;
using MyTrainingDiary.Exceptions;
using Microsoft.EntityFrameworkCore;
using MyTrainingDiary.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using MyTrainingDiary.Services;

namespace MyTrainingDiary.ViewModels
{
    public class LoginPageVM : ViewModelBase
    {
        private IUserRepo _userRepo;
        private IUserAuthenticationService _userAuthService;

        public string Username { get; set; }
        public string Password { get; set; }
        public INavigation Navigation { get; private set; }
        public ICommand SignInCommand { protected set; get; }
        public ICommand RegisterNewUserCommand { protected set; get; }
        public bool RegisterButtonEnabled { get; } = false; // todo odstranit, jak bude implementovano

        public LoginPageVM() { } // pro XAML binding.context, zpristupnuje vlastnosti VM, jinak nejsou videt (zatim jsem na to lip neprisel)

        public LoginPageVM(INavigation navigation, IUserRepo userRepo, IUserAuthenticationService service)
        {
            Navigation = navigation;
    
            _userRepo = userRepo;
            _userAuthService = service;

            Username = string.Empty;
            Password = string.Empty;

            SignInCommand = CreateSignInCommand();
            RegisterNewUserCommand = CreateRegisterNewUserCommand();
        }

        private async Task OnLogin(Guid verifiedUserId)
        {
            await Navigation.PushAsync(new MainTabbedPage(Navigation, verifiedUserId));
        }

        private Command CreateSignInCommand()
        {
            return new Command(async () =>
            {
                IUserCredentials userCredentials = new UserCredentialsModel(Username, Password);

                _userAuthService.VerifyUserCredentials(userCredentials, out var verificationResult);

                if (verificationResult)
                {
                    try
                    {
                        Guid verifiedUserId = _userRepo.GetUserIdByUserCredentials(userCredentials);

                        await OnLogin(verifiedUserId);
                    }
                    catch (NoUserException e)
                    {
                        // todo nejaka reakce kdyz uzivatel nebyl nalezen
                    }
                }
                else
                {
                    // todo nejaka reakce, kdyz se uzivatele nepovedlo overit
                }
            });
        }

        private Command CreateRegisterNewUserCommand()
        {
            return new Command(() =>
            {
                // todo CreateRegisterNewUserCommand()
                // asi bude jen davat navigaci na new reg. page
            });
        }
    }
}
