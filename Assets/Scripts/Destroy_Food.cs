using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Food : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
        }
    }
}
