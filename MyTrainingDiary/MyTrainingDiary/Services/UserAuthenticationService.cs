using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;
using MyTrainingDiary.Exceptions;

namespace MyTrainingDiary.Services
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        private IUserCredentialsRepo _userCredentialsRepo;

        public UserAuthenticationService(IUserCredentialsRepo repo)
        {
            _userCredentialsRepo = repo;
        }

        public void VerifyUserCredentials(IUserCredentials givenUserCredentials, out bool verificationResult)
        {
            try
            {
                var foundUserCredentials = _userCredentialsRepo.GetUserCredentialsByUsername(givenUserCredentials.Username);

                if (givenUserCredentials.Password == foundUserCredentials.Password)
                {
                    givenUserCredentials.Id = foundUserCredentials.Id; // todo mozna spis vracet nove credentials s nalezenym ID???
                    verificationResult = true;
                    return;
                }
            }
            catch (NoUserException e)
            {
                verificationResult = false;
            }

            verificationResult = false;
        }
    }
}
