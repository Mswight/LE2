using BlogDataLibrary.Database;

namespace BlogDataLibrary.Data
{
    public class SqlData
    {
        private readonly ISqlDataAccess db;
        private readonly string connectionStringName = "Default";

        public SqlData(ISqlDataAccess db)
        {
            this.db = db;
        }

        // You’ll add methods here later to interact with Users and Posts
    }
}
