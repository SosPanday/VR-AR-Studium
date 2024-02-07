using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingApply : MonoBehaviour
{
    public void ApplyType()
    {
        int ty = GetComponent<TMP_Dropdown>().value;
    if (ty == 0)
        StaircaseGenerator.stastairType = StairType.Glass;
        if(ty == 1)
            StaircaseGenerator.stastairType = StairType.Wood;
        if(ty == 2)
            StaircaseGenerator.stastairType = StairType.Stone;
    }

    public void ApplyLength()
    {
        float l = GetComponent<Slider>().value;
        StaircaseGenerator.stastairLength = (int)(6 + l*20);
    }
}
