/*Fetching Info from Database*/

using System.Collections.Generic;

namespace SQLCommunications
{
    public class FetchData
    {
        public static ItemDisc getItemInfo(string s)
        {
            return Receiver.ReadFromProduct("SELECT * from Product WHERE name =" + s)[0];
        }
        
        public static string getProductDetail(string productName, string Detail)
        {
            float x;
            if (Detail == "type")
            {
                return Receiver.ReadFromProduct("SELECT Detail FROM Product WHERE name =" + productName)[0].Type;
            }
            else if (Detail == "price")
            {
                x = Receiver.ReadFromProduct("SELECT Detail FROM Product WHERE name =" + productName)[0].price;
                return x.ToString();
            }
            else if (Detail == "quantity")
            {
                x = Receiver.ReadFromProduct("SELECT Detail FROM Product WHERE name =" + productName)[0].Quantity;
                return x.ToString();
            }
            else return "Null";

        }

        public static List<ItemDisc> category(string s)
        {
            return new List<ItemDisc>(Receiver.ReadFromProduct("select * from Product where category=s"));
        }

        public static bool checkPass(string user, string pass)
        {
            User[] x = Receiver.ReadFromAccounts("select* from Accounts where username=user");
            if (x.Length == 0) return false;
            else if (pass == x[0].Password)
            {
                return true;
            }
            else return false;
        }
    }
}


