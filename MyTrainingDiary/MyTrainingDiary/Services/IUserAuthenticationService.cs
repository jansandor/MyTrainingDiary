using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;

namespace MyTrainingDiary.Services
{
    public interface IUserAuthenticationService
    {
        void VerifyUserCredentials(IUserCredentials givenUserCredentials, out bool verificationResult);
    }
}
