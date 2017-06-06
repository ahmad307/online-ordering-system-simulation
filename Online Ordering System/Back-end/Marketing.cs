using System.Collections.Generic;

class Marketing
{
    static SortedDictionary<ItemDisc, int> Items;
    static void Buy(ItemDisc ordered,int quantity)
    {
        Items[ordered] += quantity;
    }
    static bool remove(ItemDisc ordered,int quantity)
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
    static SortedDictionary<ItemDisc,int> show()
    {
        return Items;
    }
    static void Sort_Prize(List<ItemDisc> C_items)
    {
        
    }
    static void sort_name(List<ItemDisc> C_items)
    {

    }
}