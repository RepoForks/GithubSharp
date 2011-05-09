namespace GithubSharp.Core.Models
{
    public class GithubUser
    {
        public string Name { get; set; }
        /* Depricated */
        public string APIToken
        {
            get { return OathToken; }
            set { OathToken = value; }
        }
        public string Password { get; set; }
        public string OathToken { get; set; }
    }
}
