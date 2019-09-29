using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * -0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * -0.1f);
        }

        if (this.transform.position.x >= 4)
        {
            this.transform.position = new Vector3(4, -1.25f, 0);
        }
        if(this.transform.position.x <= -4)
        {
            this.transform.position = new Vector3(-4, -1.25f, 0);
        }
    }
}
