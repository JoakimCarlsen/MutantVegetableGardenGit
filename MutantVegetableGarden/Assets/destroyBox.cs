using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBox : MonoBehaviour
{
    public GameObject destroyedVersion;

    public void BreakBox() { 
        Instantiate(destroyedVersion, transform.position,transform.rotation, transform.parent);
        Destroy(gameObject);
    }
}
