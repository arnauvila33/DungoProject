using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObject : MonoBehaviour
{
    [SerializeField]
    private bool Invisible;
    [SerializeField]
    private Sprite invisibleSprite;
    [SerializeField]
    private Sprite visibleSprite;

    [SerializeField]
    private Transform doorLocation;

    [SerializeField]
    private bool endLevel;
    // Start is called before the first frame update
    void Start()
    {
        if (Invisible) GetComponent<SpriteRenderer>().sprite = invisibleSprite;
    }

    public void SetVisible()
    {
        Invisible = false;
        GetComponent<SpriteRenderer>().sprite = visibleSprite;
    }

    public void SetInvisible()
    {
        Invisible = true;
        GetComponent<SpriteRenderer>().sprite = invisibleSprite;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&collision.GetComponent<PlayerInfo>().getItem().name.Equals("Key"))
        {
            if (!endLevel) collision.GetComponent<Transform>().position = doorLocation.position;
        }
    }
}
