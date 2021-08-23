namespace Singleton.Database
{
    public class Database
    {
        private static Database instance;
        public int ID { get; set; }

        private Database()
        {
            ID = 9999;
        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

    }
}
