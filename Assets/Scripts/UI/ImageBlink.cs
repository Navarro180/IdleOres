using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageBlink : MonoBehaviour
{
    public Image image;

    public Color red => Color.red;
    public Color black => Color.black;

    public float speed = 1;

    public void Update()
    {
        image.color = ImageChange();
    }

    public Color ImageChange()
    {
        return Color.Lerp(black, red, Mathf.Sin(Time.time * speed));
    }
}
