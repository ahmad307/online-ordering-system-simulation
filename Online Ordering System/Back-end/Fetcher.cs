/*Fetching Info from Database*/


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
    }
}


