using UnityEngine;
using System.Collections;

public class Handle : MonoBehaviour
{
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 0, 1), 60);
        }
    }
}
    