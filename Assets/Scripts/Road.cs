using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Road : MonoBehaviour
{
    private BoxCollider boxCollider; 
    void Start()
    {
        boxCollider = GetComponentInChildren<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<CubeMovement>(out CubeMovement player))
        {
            Debug.Log("IN");
            player.ChangeBounbaries();
            player.IsTurnOpen = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent<CubeMovement>(out CubeMovement player))
        {
            Debug.Log("OUT");
            //player.IsTurnOpen = false;
        }
    }
}
