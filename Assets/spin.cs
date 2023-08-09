using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float changeSpeed = 20f;
    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0f, 1f, 0f) * Time.deltaTime * changeSpeed);
    }
}
