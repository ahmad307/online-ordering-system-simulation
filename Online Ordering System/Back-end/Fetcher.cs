/*Fetching Info from Database*/


namespace SQLCommunications
{
    public class FetchData
    {
        public static ItemDisc getItemInfo(string s)
        {
            ItemDisc l= Receiver.ReadFromTable("SELECT * from Product WHERE name ="+ s)[0];
            return l;
        }

        public static string getProductDetail(string productName, string Detail)
        {
            string l;   float x;
            if (Detail == "type")
            { return l = Receiver.ReadFromTable("SELECT Detail FROM Product WHERE name =" + productName)[0].Type; }
            else if (Detail == "price")
            {
                x = Receiver.ReadFromTable("SELECT Detail FROM Product WHERE name =" + productName)[0].price;
                return l = x.ToString();
            }
            else if (Detail == "quantity")
            {
                x = Receiver.ReadFromTable("SELECT Detail FROM Product WHERE name =" + productName)[0].Quantity;
                return l = x.ToString();
            }
            else return "Null";

        }
    }
}


