using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    public GameObject objectToAnimate;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToAnimate.GetComponent<Animator>().SetTrigger("TriggerAnimation");
        }
    }
}