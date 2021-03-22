using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       // Destroy(other.gameObject);
        Camera.main.transform.position = new Vector3(0, 0, 0);
    }

}
