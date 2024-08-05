using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        summa(2);
        summa(1);
        againSumma(1, 2, "VIshal");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void summa(int number)
    {
        print(number);  
    }

    public void againSumma(int No, int no2, string hello)
    {
        print(No + no2);

    }
}
