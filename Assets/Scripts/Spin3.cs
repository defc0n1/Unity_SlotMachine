using UnityEngine;
using System.Collections;

public class Spin3 : MonoBehaviour
{

    private bool isSpinning = false;
    private float spinCounter = 0;
    private float spinStep = 360.0f / 4.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            isSpinning = !isSpinning;
            spinCounter = Random.Range(170, 200);
        }

        if (isSpinning && spinCounter > 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
            --spinCounter;
        }
        else if (isSpinning && spinCounter <= 0)
        {
            isSpinning = false;
        }
        if (isSpinning == false && Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
        }
    }
}
