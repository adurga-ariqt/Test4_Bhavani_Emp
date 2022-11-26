namespace Test4_Bhavani_Emp
{
    internal class SqlCommand
    {
        private string query;
        private SqlConnection con;

        public SqlCommand(string query, SqlConnection con)
        {
            this.query = query;
            this.con = con;
        }

        public object Parameters { get; internal set; }

        internal void Clone()
        {
            throw new NotImplementedException();
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}