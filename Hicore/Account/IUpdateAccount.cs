using System;
using Hicore.Results;

namespace Hicore.Account
{
    interface IUpdateAccount
    {

        void Username(string newUsername, Action<Result> onResult);
        void Password(string oldPassword, string newPassword, Action<Result> onResult);
        void Email(string newEmail, Action<Result> onResult);
        void UserProfile(Profile profile, Action<Result> onResult);
    }
}
