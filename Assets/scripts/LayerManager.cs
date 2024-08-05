using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    [SerializeField] private string[] layers = { "Default", "noColl" };
    private void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other, index:1) ;
    }
    private void OnTriggerExit(Collider other)
    {
        ChangeLayer(other, index:0);
    }
    private void ChangeLayer(Collider other,int index)
    {
        other.gameObject.layer = LayerMask.NameToLayer(layers[index]);
    }

}
