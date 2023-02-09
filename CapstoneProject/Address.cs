using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969Assessment
{
    public class Address : Record
    {
        // 4 FEB 2023 - Implemented Record parent class
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }

        public static MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM address", DatabaseConnection.connection);

        public static List<Address> addressList = getAddresses();

        // Default constructor
        public Address()
        {
        }

        public Address(int addressId, string address, string address2, int cityId, string postalCode, string phone, string createDate, string createdBy, string lastUpdate, string lastUpdateBy)
        {
            this.Id = addressId;
            this.address = $"'{address}'";
            this.address2 = $"'{address2}'";
            this.cityId = cityId;
            this.postalCode = $"'{postalCode}'"; ;
            this.phone = $"'{phone}'"; ;
            this.createDate = $"'{createDate}'";
            this.createdBy = $"'{createdBy}'";
            this.lastUpdate = $"'{lastUpdate}'";
            this.lastUpdateBy = $"'{lastUpdateBy}'";

            addressList.Add(this);
        }

        // Query database for all addresses, then store each in an Address object, which is then tracked in a list of addresses
        public static List<Address> getAddresses()
        {
            List<Address> addresses = new List<Address>();
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Address address = new Address();
                address.Id = reader.GetInt32("addressId");
                address.address = reader.GetString("address");
                address.address2 = reader.GetString("address2");
                address.cityId = reader.GetInt32("cityId");
                address.postalCode = reader.GetString("postalCode");
                address.phone = reader.GetString("phone");
                address.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                address.createdBy = reader.GetString("createdBy");
                address.lastUpdate = reader.GetDateTime("lastUpdate").ToLocalTime().ToString();
                address.lastUpdateBy = reader.GetString("lastUpdateBy");

                addresses.Add(address);
            }
            reader.Close();

            return addresses;
        }

        // Add an address to the database
        public static void addToDb(Address address)
        {
            MySqlCommand addCmd = new MySqlCommand("INSERT INTO address(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(" + address.Id + "," + address.address + "," + address.address2 + "," + address.cityId + "," + address.postalCode + "," + address.phone + "," + address.createDate + "," + address.createdBy + "," + address.lastUpdate + "," + address.lastUpdateBy + ");", DatabaseConnection.connection);
            addCmd.ExecuteNonQuery();
            addressList = getAddresses();
        }

        // Modify an address entry in the database
        public static void modifyDb(Address address)
        {
            MySqlCommand updateCmd = new MySqlCommand("UPDATE address SET address = " + address.address + ", " + "address2 = " + address.address2 + ", " + "cityId = " + address.cityId + ", " + "postalCode = " + address.postalCode + ", " + "phone = " + address.phone + ", " + "createDate = " + address.createDate + ", " + "createdBy = " + address.createdBy + ", " + "lastUpdate = " + address.lastUpdate + ", " + "lastUpdateBy = " + address.lastUpdateBy + "WHERE addressId = " + address.Id + ";", DatabaseConnection.connection);
            updateCmd.ExecuteNonQuery();

            addressList = getAddresses();
        }
    }
}