namespace Refactoring2
{
    public class CacherDecorator : DecoratorBase
    {
        private readonly ICacher _cache;   
        public CacherDecorator(IDataProvider provider, ICacher cache): base(provider)
        {
            _cache = cache;
        }
        public override SomeDTO Get(QueryDTO query)
        {
            string key = Json.Convert.SerializeObject(query);
            if (_cache.Contains(key))
            {
                return _cache.Get(key);
            }
            else
            {
                var result = _provider.Get(query);
                _cache.Add(key, result);
                return result;
            }
        }
    }

    public interface ICacher
    {
        bool Contains(string key);
        SomeDTO Get(string key);
        string Add(string key, SomeDTO result);
    }


}
