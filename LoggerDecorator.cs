namespace Refactoring2
{
    public class LoggerDecorator : DecoratorBase
    {
        private readonly ILogger _log;
        public LoggerDecorator(IDataProvider provider, ILogger log): base(provider)
        {
            _log = log;
        }

        public override SomeDTO Get(QueryDTO query)
        {
            try
            {
                var result = _provider.Get(query);
                return result;
            }
            catch(Exception e)
            {
                _log.Log(e.Message);
            }
            return 1;
        }

        public interface ILogger
        {
            void Log(string message);
        }
    }
}
