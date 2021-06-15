using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorColider : MonoBehaviour
{
    bool isNewArea = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("must go to new scene");
    }
}
