/*Fetching Info from Database*/

using SQLCommunications;
using System.Collections.Generic;

public class FetchData
{
    public static ItemDisc GetItemInfo(string s)    //returns ItemDisc struct with product's information
    {
        return Receiver.ReadFromProduct("SELECT * from Product WHERE name = '" + s + "';")[0];
    }
    
    public static List<ItemDisc> Category(string s) //return a struct list of products in a certain category
    {
        return new List<ItemDisc>(Receiver.ReadFromProduct("SELECT * FROM Product WHERE type = '" + s + "';"));
    }

    public static bool CheckPass(string user, string pass)  //checks if entered password matches the user name
    {
        User[] x = Receiver.ReadFromAccounts("SELECT * FROM Accounts WHERE username = N'" + user + "';");
        if (x.Length == 0) return false;
        else if (pass == x[0].Password)
        {
            return true;
        }
        else return false;
    }

    public static List<string> AllCategories()     //returns all categories in database
    {
        SortedDictionary<string, int> D = new SortedDictionary<string, int>();
        List<string> temp = new List<string>();

        ItemDisc[] x = Receiver.ReadFromProduct("SELECT * FROM Product;");
        for(int i = 0; i < x.Length; i++)
        {
            D[x[i].Type] = 0;
        }
        for (int i = 0; i < x.Length; i++)
        {
            if (D[x[i].Type] == 0)
            {
                D[x[i].Type]++;
                temp.Add(x[i].Type);
            }
        }

        return temp;
    }
}



