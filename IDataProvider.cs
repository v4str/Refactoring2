namespace Refactoring2
{
    public interface IDataProvider
    {
        public SomeDTO Get(QueryDTO query);
    }
}
