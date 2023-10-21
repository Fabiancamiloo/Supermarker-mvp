namespace Supermarker_mvp._Repositories
{
    internal class SqlConnection : IDisposable
    {
        public SqlConnection(string connectionString)
        {
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Microsoft.Data.SqlClient.SqlConnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}