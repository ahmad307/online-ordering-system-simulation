using System;

public struct ItemDisc : IComparable
{
    public static int ComparisonCo = 0;
    public int ID;
    public string name;
    public float price;
    public int Quantity;
    public string Type;
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