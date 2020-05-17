using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab_Switch : MonoBehaviour
{


    public Image[] Holder;

    [SerializeField] public Sprite[] Top;
    [SerializeField] public Sprite[] Mid;
    [SerializeField] public Sprite[] Bot;

    public void Switch_Image_Top()
    {
        if (Holder[0].sprite == Top[0])
            Holder[0].sprite = Top[1];
        else if (Holder[0].sprite == Top[1])
            Holder[0].sprite = Top[2];
        else if (Holder[0].sprite == Top[2])
            Holder[0].sprite = Top[3];
        else if (Holder[0].sprite == Top[3])
            Holder[0].sprite = Top[4];
        else if (Holder[0].sprite == Top[4])
            Holder[0].sprite = Top[5];
        else if (Holder[0].sprite == Top[5])
            Holder[0].sprite = Top[0];
    }

    public void Switch_Image_Mid()
    {
        if (Holder[1].sprite == Mid[0])
            Holder[1].sprite = Mid[1];
        else if (Holder[1].sprite == Mid[1])
            Holder[1].sprite = Mid[2];
        else if (Holder[1].sprite == Mid[2])
            Holder[1].sprite = Mid[3];
        else if (Holder[1].sprite == Mid[3])
            Holder[1].sprite = Mid[4];
        else if (Holder[1].sprite == Mid[4])
            Holder[1].sprite = Mid[5];
        else if (Holder[1].sprite == Mid[5])
            Holder[1].sprite = Mid[0];
    }

    public void Switch_Image_Bot()
    {
        if (Holder[2].sprite == Bot[0])
            Holder[2].sprite = Bot[1];
        else if (Holder[2].sprite == Bot[1])
            Holder[2].sprite = Bot[2];
        else if (Holder[2].sprite == Bot[2])
            Holder[2].sprite = Bot[3];
        else if (Holder[2].sprite == Bot[3])
            Holder[2].sprite = Bot[4];
        else if (Holder[2].sprite == Bot[4])
            Holder[2].sprite = Bot[5];
        else if (Holder[2].sprite == Bot[5])
            Holder[2].sprite = Bot[0];
    }
}
