using System;

public struct ItemDisc : IComparable
{
    int ID;
    string name;
    float price;
    public int CompareTo(object o)
    {
        if (o.GetType() == GetType())
        {
            return ID.CompareTo(((ItemDisc)o).ID);
        }
        else return 0;
    }
};