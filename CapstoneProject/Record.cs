using MySql.Data.MySqlClient;

namespace C969Assessment
{
    public class Record
    {
        public int Id { get; set; }
        public string createDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public static MySqlDataReader reader;

    }
}
