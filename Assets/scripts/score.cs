using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI text;


    public void updatePoints(float scale)
    {
        text.text=scale.ToString() ;
    }
}
