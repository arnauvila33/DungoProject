using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private string name;

    private Object itemImage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
        }
    }

    private void addItem()
    {
        //Gamehandler.itemImage = gameObject.GetComponent<SpriteRenderer>().sprite;
    }
}
