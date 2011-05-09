

namespace GithubSharp.Plugins.CacheProviders.DoNotCacher
{
    public class DoNotCacher : Core.Services.ICacheProvider
    {
        #region ICacheProvider Members

        public T Get<T>(string Name) where T : class
        {
            return null;
        }

        public T Get<T>(string Name, int CacheDurationInMinutes) where T : class
        {
            return null;
        }

        public bool IsCached<T>(string Name) where T : class
        {
            return false;
        }

        public void Set<T>(T ObjectToCache, string Name) where T : class
        {
        }

        public void Delete(string Name)
        {
        }

        public void DeleteWhereStartingWith(string Name)
        {
        }

        public void DeleteAll<T>() where T : class
        {
        }

        public int DefaultDuractionInMinutes
        {
            get { return default(int); }
        }

        #endregion
    }
}
