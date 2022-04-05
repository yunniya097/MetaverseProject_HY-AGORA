using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStay : MonoBehaviour
{
    public float RotSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, RotSpeed * Time.deltaTime, 0));
    }
}
