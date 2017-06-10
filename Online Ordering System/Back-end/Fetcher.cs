/*Fetching Info from Database*/

using System.Collections.Generic;

namespace SQLCommunications
{
    public class FetchData
    {
        public static ItemDisc GetItemInfo(string s)
        {
            return Receiver.ReadFromProduct("SELECT * from Product WHERE name = '" + s + "';")[0];
        }

        public static string GetProductDetail(string productName, string Detail)
        {
            float x;
            if (Detail == "type")
            {
                return Receiver.ReadFromProduct("SELECT * FROM Product WHERE name = '" + productName + "';")[0].Type;
            }
            else if (Detail == "price")
            {
                x = Receiver.ReadFromProduct("SELECT * FROM Product WHERE name = '" + productName + "';")[0].price;
                return x.ToString();
            }
            else if (Detail == "quantity")
            {
                x = Receiver.ReadFromProduct("SELECT * FROM Product WHERE name = '" + productName + "';")[0].Quantity;
                return x.ToString();
            }
            else return "Null";

        }

        public static List<ItemDisc> Category(string s)
        {
            return new List<ItemDisc>(Receiver.ReadFromProduct("SELECT * FROM Product WHERE category = '" + s + "';"));
        }

        public static bool CheckPass(string user, string pass)
        {
            User[] x = Receiver.ReadFromAccounts("SELECT * FROM Accounts WHERE username = '" + user + "';");
            if (x.Length == 0) return false;
            else if (pass == x[0].Password)
            {
                return true;
            }
            else return false;
        }
    }
}


