using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    private List<Object> specter=new List<Object>();
    private Object item;
    private int coins;
    
    public void AddCoin()
    {
        coins++;
    }

    public void SetItem(Object item)
    {
        this.item = item;
    }

    public void AddSpecter(Object specter)
    {
        this.specter.Add(specter);
    }

    public Object getItem()
    {
        return item;
    }
}
