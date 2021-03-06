﻿using System.Collections.Generic;

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
    public static List<ItemDisc> Advanced_filter(List<ItemDisc> C_items, string search, bool word, bool match_case, float min = 0, float max = 1000000000)
    {
        
        List<ItemDisc> Send = new List<ItemDisc>();
 
        if (!word)
        {
            string sub_word;
            if (!match_case)
                sub_word = search.ToLower();
            else
                sub_word = search;
            foreach (ItemDisc c in C_items)
            {
                string z;
                if (!match_case)
                    z = c.name.ToLower();
                else
                    z = c.name;
                if (z.Contains(sub_word) && c.price >= min && c.price <= max)
                    Send.Add(c);
            }
        }
        else
        {
            string sub_word = " ";
            if (!match_case)
                sub_word += search.ToLower();
            else
                sub_word += search;
            sub_word += " ";
            foreach (ItemDisc c in C_items)
            {
                string z = " ";
                if (!match_case)
                    z += c.name.ToLower();
                else
                    z += c.name;
                z += " ";
                if (z.Contains(sub_word) && c.price >= min && c.price <= max)
                    Send.Add(c);
            }
        }
        return Send;

    }
}