using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace C969Assessment
{
    public class Customer : Record
    {
        public string customerName { get; set; }
        public int addressId { get; set; }
        public byte active { get; set; }

        private static MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
            "SELECT * FROM customer",
            DatabaseConnection.connection
        );

        public static List<Customer> custList = getCustomers();

        public Customer() { }

        public Customer(
            int customerId,
            string customerName,
            int addressId,
            byte active,
            string createDate,
            string createdBy,
            string lastUpdate,
            string lastUpdateBy
        )
        {
            this.Id = customerId;
            this.customerName = $"'{customerName}'";
            this.addressId = addressId;
            this.active = active;
            this.createDate = $"'{createDate}'";
            this.createdBy = $"'{createdBy}'";
            this.lastUpdate = $"'{lastUpdate}'";
            this.lastUpdateBy = $"'{lastUpdateBy}'";

            custList.Add(this);
        }

        public static List<Customer> getCustomers(string searchStr)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                searchStr,
                DatabaseConnection.connection
            );

            List<Customer> customers = new List<Customer>();

            if (searchStr.Length == 0)
            {
                return customers;
            }
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = reader.GetInt32("customerId");
                customer.customerName = reader.GetString("customerName");
                customer.addressId = reader.GetInt32("addressId");
                customer.active = reader.GetByte("active");
                customer.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                customer.createdBy = reader.GetString("createdBy");
                customer.lastUpdate = reader.GetDateTime("lastUpdate").ToLocalTime().ToString();
                customer.lastUpdateBy = reader.GetString("lastUpdateBy");

                customers.Add(customer);
            }
            reader.Close();

            return customers;
        }

        public static List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = reader.GetInt32("customerId");
                customer.customerName = reader.GetString("customerName");
                customer.addressId = reader.GetInt32("addressId");
                customer.active = reader.GetByte("active");
                customer.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                customer.createdBy = reader.GetString("createdBy");
                customer.lastUpdate = reader.GetDateTime("lastUpdate").ToLocalTime().ToString();
                customer.lastUpdateBy = reader.GetString("lastUpdateBy");

                customers.Add(customer);
            }
            reader.Close();

            return customers;
        }

        public static string getNameById(int id)
        {
            MySqlCommand searchCmd = new MySqlCommand(
                $"SELECT customerName FROM customer WHERE customerId = {id}",
                DatabaseConnection.connection
            );
            string name = "";
            reader = searchCmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString("customerName");
            }
            reader.Close();

            return name;
        }

        public static int getIdByName(string name)
        {
            int id = 0;
            MySqlCommand searchCmd = new MySqlCommand(
                $"SELECT customerId FROM customer WHERE customerName LIKE '%{name}%'",
                DatabaseConnection.connection
            );
            reader = searchCmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32("customerId");
            }
            reader.Close();
            return id;
        }

        public static bool custHasAddress(int addressId)
        {
            foreach (Customer customer in custList)
            {
                if (customer.addressId == addressId)
                {
                    return true;
                }
            }
            return false;
        }

        public static void addToDb(Customer customer)
        {
            MySqlCommand addCmd = new MySqlCommand(
                "INSERT INTO customer(customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES("
                    + customer.Id
                    + ","
                    + customer.customerName
                    + ","
                    + customer.addressId
                    + ","
                    + customer.active
                    + ","
                    + customer.createDate
                    + ","
                    + customer.createdBy
                    + ","
                    + customer.lastUpdate
                    + ","
                    + customer.lastUpdateBy
                    + ");",
                DatabaseConnection.connection
            );
            addCmd.ExecuteNonQuery();
            custList = getCustomers();
        }

        public static void modifyDb(Customer customer)
        {
            MySqlCommand updateCmd = new MySqlCommand(
                "UPDATE customer SET customerName = "
                    + customer.customerName
                    + ", "
                    + "addressId = "
                    + customer.addressId
                    + ", "
                    + "active = "
                    + customer.active
                    + ", "
                    + "lastUpdate = "
                    + customer.lastUpdate
                    + ", "
                    + "lastUpdateBy = "
                    + customer.lastUpdateBy
                    + "WHERE customerId = "
                    + customer.Id
                    + ";",
                DatabaseConnection.connection
            );
            updateCmd.ExecuteNonQuery();

            custList = getCustomers();
        }
    }
}
