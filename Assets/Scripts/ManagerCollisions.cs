using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
