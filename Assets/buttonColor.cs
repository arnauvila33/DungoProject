using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColor : MonoBehaviour
{
    public Image button;
    public Image button2;
    public Image button3;

    public void Start()
    {
        button.color = new Color(0, 0, 0, 0f);
        button2.color = new Color(0, 0, 0, 0f);
        button3.color = new Color(0, 0, 0, 0f);
    }
}
