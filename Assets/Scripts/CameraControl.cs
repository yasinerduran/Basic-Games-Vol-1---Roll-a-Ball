using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContro : MonoBehaviour
{
    public GameObject ball; 
    Vector3 distanceOfFollow;
    // Start is called before the first frame update
    void Start()
    {
        distanceOfFollow = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() // For escape for frezze
    {
        transform.position = ball.transform.position + distanceOfFollow;
    }
}
