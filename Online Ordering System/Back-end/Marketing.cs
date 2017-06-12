using System.Collections.Generic;

public class Marketing
{
    private List<ItemDisc> Items = new List<ItemDisc>();
    
    public void Buy(ItemDisc ordered)
    {
        bool found = false;
        for(int i = 0; i < Items.Count; i++)
        {
            if(Items[i].name == ordered.name)
            {
                ItemDisc C = Items[i];
                C.Quantity += ordered.Quantity;
                Items.RemoveAt(i);
                Items.Add(C);
                found = true;
                break;
            }
        }
        if(!found)
        {
            Items.Add(ordered);
        }
    }
    public bool Remove(ItemDisc ordered)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].name == ordered.name)
            {
                if (Items[i].Quantity >= ordered.Quantity)
                {
                    ItemDisc C = Items[i];
                    C.Quantity -= ordered.Quantity;
                    Items.RemoveAt(i);
                    if(C.Quantity != 0)
                        Items.Add(C);
                    return true;
                }
                break;
            }
        }
        return false;
    }
    public List<ItemDisc> UserList()
    {
        return Items;
    }
}

static class functions
{
    public static void Sort_Prize(List<ItemDisc> C_items)
    {
        ItemDisc.ComparisonCo = 2;
        C_items.Sort();
    }
    public static void sort_name(List<ItemDisc> C_items)
    {
        ItemDisc.ComparisonCo = 1;
        C_items.Sort();
    }
    public static List<ItemDisc> Search_items (string sub, List <ItemDisc> C_items)
    {
        List<ItemDisc> Send = new List<ItemDisc>();
        sub = sub.ToLower();
        foreach(ItemDisc c in C_items)
        {
            string z = c.name.ToLower();
            if (z.Contains(sub))
                Send.Add(c);
        }
        return Send;
    }
    public static List<ItemDisc> Filter(List<string> Companies, List<ItemDisc> C_items, int low = 0, int high = int.MaxValue)
    {
        List<ItemDisc> send = new List<ItemDisc>();
        foreach(ItemDisc c in C_items)
        {
            if (Companies.Contains(c.manfacture) && c.price >= low && c.price <= high)
            { 
                send.Add(c);
           }
        }
        return send;
    }
}