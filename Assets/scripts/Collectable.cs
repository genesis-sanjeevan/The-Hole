using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] Status status;
    [SerializeField] float points;
    [SerializeField] private float size;

    public float GetSize()
    {
        if(status == Status.collectables)
        {
            return size;
        }
        else
        {
            return -size;
        }
    }

    public float GetPoints()
    {
        if (status == Status.collectables)
        {
            return points;
        }
        else
        {
            return -points;
        }
        
    }
}


    

public enum Status
{
    collectables,
    uncollectables
}