namespace Test4_Bhavani_Emp
{
    internal class SqlConnection
    {
        private string? connection;

        public SqlConnection(string? connection)
        {
            this.connection = connection;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}