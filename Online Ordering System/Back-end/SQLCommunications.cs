using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace SQLCommunications
{
    ///<summary>
    ///This is the class that contains what other classes have in common
    ///</summary>
    public class CommBase
    {
        public enum TableType { Product, Accounts, Orders };
        public static bool IsIntialized = false;
        public static SqlCommand command = new SqlCommand();
        public static SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\OOSDB.mdf;Integrated Security = True");
        public static SqlDataReader reader;
        ///<summary>
        ///Connects to the SQL database
        ///</summary>
        public static void Intialize()
        {
            if (!IsIntialized)
            {
                connection.Open();
                command.Connection = connection;
                IsIntialized = true;
            }
        }
        ///<summary>
        ///Disconnects database
        ///</summary>
        public static void ShutDown()
        {
            connection.Close();
            IsIntialized = false;
        }
        ///<summary>
        ///Execute a query that doesn't return anything
        ///</summary>
        public static void ExecuteNoReturn(string Query)
        {
            command.CommandText = Query;
            command.ExecuteNonQuery();
        }
        ///<summary>
        ///A unified functions that reads from any table
        ///</summary>
        public static object ReadFromTable(string Query, TableType t)
        {
            Intialize();
            command.CommandText = Query;
            reader = command.ExecuteReader();
            List<object> list = new List<object>();
            while (reader.Read())
            {
                if (t == TableType.Product)
                {
                    ItemDisc i;
                    i.ID = (int)reader["id"];
                    i.name = (string)reader["name"];
                    i.price = (float)reader["price"];
                    i.Quantity = (int)reader["quantity"];
                    i.Type = (string)reader["type"];
                    i.manfacture = " ";
                    i.state = DeliveryState.Pending;
                    list.Add(i);
                }
                else if (t == TableType.Accounts)
                {
                    User i;
                    i.ID = (int)reader["id"];
                    i.Username = (string)reader["username"];
                    i.Password = (string)reader["password"];
                    i.address = (string)reader["address"];
                    i.process = new Marketing();
                    list.Add(i);
                }
                else if (t == TableType.Orders)
                {
                    ItemDisc i;
                    i.ID = (int)reader["id"];
                    i.name = (string)reader["name"];
                    i.price = (float)reader["price"];
                    i.Quantity = (int)reader["quantity"];
                    i.Type = (string)reader["type"];
                    i.state = (DeliveryState)((int)reader["delievered"]);
                    i.manfacture = " ";
                    list.Add(i);
                }
            }
            reader.Close();
            return list.ToArray();
        }
    }
    ///<summary>
    ///Transmits data into database
    ///</summary>
    public class Transmitter : CommBase
    {
        ///<summary>
        ///Inserts items into Product table while checking for duplicates
        ///</summary>
        public static void InsertIntoTable(params ItemDisc[] id)
        {
            Intialize();
            ItemDisc[] Items = Receiver.ReadFromProduct("SELECT * FROM Product;");
            foreach (ItemDisc i in id)
            {
                bool FoundDublicate = false;
                foreach (ItemDisc j in Items)
                {
                    if (i.name == j.name)
                    {
                        FoundDublicate = true;
                        ExecuteNoReturn("UPDATE Product SET quantity = quantity + " + i.Quantity + " WHERE id = " + j.ID + ";");
                        break;
                    }
                }
                if (!FoundDublicate)
                {
                    ExecuteNoReturn("INSERT INTO Product (name , price , quantity , type) Values('" + i.name + "', " + i.price + ", " + i.Quantity + ", '" + i.Type + "');");
                }
            }
        }
        ///<summary>
        ///Places orders in database
        ///</summary>
        public static void PlaceOrders(User user, params ItemDisc[] id)
        {
            Intialize();
            foreach (ItemDisc i in id)
            {
                ExecuteNoReturn("INSERT INTO Orders (userid , name , price , quantity , type) Values(" + user.ID + ", '" + i.name + "' , " + i.price + ", " + i.Quantity + ", '" + i.Type + "' , 0);");
            }
        }
        ///<summary>
        ///changes order state
        ///</summary>
        public static void UpdateOrders(int OrderID, DeliveryState d)
        {
            ExecuteNoReturn("UPDATE Orders SET delievered = " + (int)d + " WHERE id = " + OrderID + ";");
        }
        ///<summary>
        ///Checks if a user exists
        ///</summary>
        public static bool CheckUser(User user)
        {
            Intialize();
            User[] AllUsers = Receiver.ReadFromAccounts("SELECT * FROM Accounts;");
            foreach (User i in AllUsers)
            {
                if (i.Username == user.Username)
                {
                    return false;
                }
            }
            return true;
        }
        ///<summary>
        ///Registers a user , returns false if username already exists
        ///</summary>
        public static bool RegisterUser(User user)
        {
            if (CheckUser(user))
            {
                ExecuteNoReturn("INSERT INTO Accounts (username , password) VALUES ('" + user.Username + "','" + user.Password + "');");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    ///<summary>
    ///Recieves data from database
    ///</summary>
    public class Receiver : CommBase
    {
        ///<summary>
        ///returns products from Product table according to the query specified via the ItemDisc struct
        ///</summary>
        public static ItemDisc[] ReadFromProduct(string Query)
        {
            object[] obj = ReadFromTable(Query, TableType.Product) as object[];
            List<ItemDisc> list = new List<ItemDisc>();
            foreach (object o in obj)
            {
                list.Add((ItemDisc)o);
            }
            return list.ToArray();
        }
        public static ItemDisc[] GetAllProducts()
        {
            return ReadFromProduct("SELECT * FROM Product;");
        }
        ///<summary>
        ///returns users from Accounts table according to the query specified via User struct
        ///</summary>
        public static User[] ReadFromAccounts(string Query)
        {
            object[] obj = ReadFromTable(Query, TableType.Accounts) as object[];
            List<User> list = new List<User>();
            foreach (object o in obj)
            {
                list.Add((User)o);
            }
            return list.ToArray();
        }
        ///<summary>
        ///returns items ordered by the given username
        ///</summary>
        public static ItemDisc[] GetOrdersOf(User user)
        {
            object[] obj = ReadFromTable("SELECT * FROM Orders WHERE userid = '" + user.ID + "';", TableType.Orders) as object[];
            List<ItemDisc> list = new List<ItemDisc>();
            foreach (object o in obj)
            {
                list.Add((ItemDisc)o);
            }
            return list.ToArray();
        }
    }
}