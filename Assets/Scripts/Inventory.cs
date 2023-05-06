using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Item
{
    public int id;
    public string name;
    public string description;
    public string icon;
}

public static class Inventory
{
    private static List<Item> items = new List<Item>();
    private static int slotsNumber;
    private static int freeSlots;

    public static bool TryAddItem(Item item)
    {
        if (freeSlots > 0)
        {
            items.Add(item);
            freeSlots--;
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void RemoveItem(Item item)
    {
        items.Remove(item);
        freeSlots++;
    }

    public static Item GetItem(string name)
    {
        Item item = items.FirstOrDefault(item => item.name == name);
        return item;
    }
}
