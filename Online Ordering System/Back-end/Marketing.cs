using System.Collections.Generic;

public class Marketing
{
    SortedDictionary<ItemDisc, int> Items;
    void Buy(ItemDisc ordered,int quantity)
    {
        Items[ordered] += quantity;
    }
    bool remove(ItemDisc ordered,int quantity)
    {
        if(quantity < 0)
        {
            return false;
        }
        else if(Items[ordered] < quantity)
        {
            return false;
        }
        else if(Items[ordered] == quantity)
        {
            Items.Remove(ordered);
            return true;
        }
        else
        {
            Items[ordered] -= quantity;
            return true;
        }
    }
    SortedDictionary<ItemDisc,int> show()
    {
        return Items;
    }
}

static class functions
{
    static void Sort_Prize(List<ItemDisc> C_items)
    {
        ItemDisc.ComparisonCo = 2;
        C_items.Sort();
    }
    static void sort_name(List<ItemDisc> C_items)
    {
        ItemDisc.ComparisonCo = 1;
        C_items.Sort();
    }
    static List<ItemDisc> Search_items (string sub, List <ItemDisc> C_items)
    {
        List<ItemDisc> Send = new List<ItemDisc>();
        foreach(ItemDisc c in C_items)
        {
            if (c.name.Contains(sub))
                Send.Add(c);
        }
        return Send;
    }
    static List<ItemDisc> Filter(List<string> Companies, List<ItemDisc> C_items, int low = 0, int high = int.MaxValue)
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

