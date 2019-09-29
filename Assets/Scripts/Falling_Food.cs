using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Food : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(Vector3.down * 0.05f);
    }
}
