using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    //private List<SpectersUI> specter=new List<SpectersUI>();
    private Object item;
    private int coins;
    private static SpriteRenderer spr;

    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
    }
    public void AddCoin()
    {
        coins++;
    }

    public void SetItem(Object item)
    {
        this.item = item;
    }

    public void AddSpecter(SpectersUI specter)
    {
        //this.specter.Add(specter);
    }

    public Object getItem()
    {
        return item;
    }

    public static void ChangeSking(SpriteRenderer rend,bool active)
    {
        if (active)
            spr.color = rend.color;
        else spr.color = Color.white;
    }

}
