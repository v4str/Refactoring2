namespace Refactoring2
{
    public class DataProvider : IDataProvider
    {
        private string user;
        private string password;
        private string connectionString;
        public DataProvider(string user, string password, string connectionString)
        {
            this.user = user;
            this.password = password;
            this.connectionString = connectionString;

        }
        public SomeDTO Get(QueryDTO query)
        {
            /*Код возвращает объект из базы*/
        }
    }
}
