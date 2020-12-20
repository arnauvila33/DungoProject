using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class Gamehandler : MonoBehaviour
{
    [SerializeField]
    private List<Tilemap> tiles;

    [SerializeField]
    private List<SpectersUI> Specters;

    [SerializeField]
    private List<Image> ui;

    public static Image ActionButton;

    public static Image itemImage;

    [SerializeField]
    private List<Color> colors;

    [SerializeField]
    private List<Color> colorsContrast;

    [SerializeField]
    private static List<SpriteRenderer> characters;

    [SerializeField]
    private List<TMP_Text> texts;

    public void Start()
    {
        itemImage = ui[3];
        ActionButton = ui[2];
        int random = UnityEngine.Random.Range(0, colors.Count);
        foreach(Tilemap tile in tiles)
        {
            tile.color = new Color(colors[random].r, colors[random].g, colors[random].b, .60f);
        }
        foreach(Image image in ui)
        {
            image.color = colors[random];
            //image.color = new Color(colors[random].r, colors[random].g, colors[random].b, .5f);
        }
        texts[0].color= colors[random];
        texts[1].color= colors[random]; 
        foreach (SpriteRenderer sprite in characters)
        {
            sprite.color = new Color(colorsContrast[random].r, colorsContrast[random].g, colorsContrast[random].b, .75f);
        }

    }

   
    public static void changeActionButton(Action f)
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((eventData) => { f(); });
        if(ActionButton.GetComponentInChildren<EventTrigger>().triggers.Count!=0)
            ActionButton.GetComponentInChildren<EventTrigger>().triggers.RemoveAt(0);      
        ActionButton.GetComponentInChildren<EventTrigger>().triggers.Add(entry);
    }

    
}
