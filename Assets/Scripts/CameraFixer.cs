using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixer : MonoBehaviour
{
    public GameObject ball; 
    Vector3 distanceOfFollow;
    // Start is called before the first frame update
    void Start()
    {
        distanceOfFollow = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = ball.transform.position + distanceOfFollow;
    }
}
