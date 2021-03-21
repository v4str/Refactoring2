namespace Refactoring2
{
    public class DecoratorBase : IDataProvider
    {
        protected readonly IDataProvider _provider;
        public DecoratorBase(IDataProvider provider)
        {
            this._provider = provider;
        }
        public virtual SomeDTO Get(QueryDTO query)
        {
            this._provider.Get(query);
        }
    }
}
