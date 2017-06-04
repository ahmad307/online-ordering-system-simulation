using System;

public struct ItemDisc : IComparable
{
    static int ComparisonCo = 0;
    int ID;
    string name;
    float price;
    public int CompareTo(object o)
    {
        if (o.GetType() == GetType())
        {
            switch (ComparisonCo)
            {
                case 0:
                    return ID.CompareTo(((ItemDisc)o).ID);
                case 1:
                    return name.CompareTo(((ItemDisc)o).name);
                default:
                    return price.CompareTo(((ItemDisc)o).price);

            }
        }
        else return 0;
    }
};