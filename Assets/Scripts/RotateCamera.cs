using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    private float horitzontalInput;
    [SerializeField] private float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horitzontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horitzontalInput * Time.deltaTime * speed);
    }
}
