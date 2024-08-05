using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{
    [SerializeField] Functions Vname;

    private void Start()
    {
        Vname.againSumma(1, 3, "hello");
    }
}
