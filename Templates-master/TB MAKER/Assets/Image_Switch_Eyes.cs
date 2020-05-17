using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Switch_Eyes : MonoBehaviour
{


    public Image Image_Holder;

    [SerializeField] public Sprite Image_1;
    [SerializeField] public Sprite Image_2;
    [SerializeField] public Sprite Image_3;

    public void Switch_Image()
    {
        if (Image_Holder.sprite == Image_1)
            Image_Holder.sprite = Image_2;
        else if (Image_Holder.sprite == Image_2)
            Image_Holder.sprite = Image_3;
        else if (Image_Holder.sprite == Image_3)
            Image_Holder.sprite = Image_1;
    }
}
