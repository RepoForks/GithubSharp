using System;

namespace GithubSharp.Core.Services
{
    public interface IAuthProvider
    {
        IAuthResponse Login(Models.GithubUser githubUser);
        IAuthResponse Logout();
        IAuthResponseWithContent<string> ModifyAPIUrl(string apiUrl);
    }

    public interface IAuthResponse
    {
        string Message { get; set; }
        bool Success { get; set; }
    }

    public interface IAuthResponseWithContent<TContentType> : IAuthResponse
    {
        TContentType Content { get; set; }
    }

    public class AuthResponse : IAuthResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class AuthResponseWithContent<TContentType> : AuthResponse, IAuthResponseWithContent<TContentType>
    {
        public TContentType Content { get; set; }
    }
}
