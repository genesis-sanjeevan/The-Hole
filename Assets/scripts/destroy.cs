using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    [SerializeField] PlayerSize playerSize;
    audio_man audio_Man;

    private void Awake()
    {
        audio_Man = GameObject.FindGameObjectWithTag("audio").GetComponent<audio_man>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        audio_Man.playsfx(audio_Man.womp);

        if (other.TryGetComponent(out Collectable collectable))
        {
            playerSize.CollectableCollected(collectable);
            Destroy(other.gameObject);

        }
    }
}
