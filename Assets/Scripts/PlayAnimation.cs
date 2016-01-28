using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour
{

    void update()
    {
        if (Input.GetKey(KeyCode.Space))
            Animation.Play();
    }
}
	