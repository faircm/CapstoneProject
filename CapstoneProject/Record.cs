using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
