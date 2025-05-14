using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetrb;
    // Start is called before the first frame update
    void Start()
    {
        targetrb = GetComponent<Rigidbody>();
        targetrb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
