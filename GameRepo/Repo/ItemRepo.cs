using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ItemRepo
{
    private readonly List<Items> _iRepo = new List<Items>();

    public bool AddItemToBackpack(Items item)
    {
        if(item != null)
        {
            _iRepo.Add(item);
            return true;
        }
        return false;
    }

    public List<Items> ViewAllItems()
    {
        return _iRepo;
    }


    public Items GetItemByID(int id)
    {
        foreach(Items i in _iRepo)
        {
            if(i.ID == id)
            {
                return i;
            }
        }
        return null;
    }

    // public bool DeleteItem(int id)
    // {
    //     var item = GetItemsByID(id);
    //     if(item != null)
    //     {
    //         _iRepo.Remove(item);
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }

    // }
}