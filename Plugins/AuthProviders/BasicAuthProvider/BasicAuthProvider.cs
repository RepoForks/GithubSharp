using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GithubSharp.Core.Services;

namespace GithubSharp.Plugins.AuthProviders.BasicAuthProvider
{
    public class BasicAuthProvider : IAuthProvider
    {
        public IAuthResponse Login(GithubSharp.Core.Models.GithubUser githubUser)
        {
            throw new NotImplementedException();
        }

        public IAuthResponse Logout()
        {
            throw new NotImplementedException();
        }

        public IAuthResponseWithContent<string> ModifyAPIUrl(string apiUrl)
        {
            throw new NotImplementedException();
        }
    }
}
