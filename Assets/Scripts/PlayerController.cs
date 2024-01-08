using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRidigbody;
    [SerializeField] private float speed = 30f;
    private float forwardInput;

    [SerializeField] private GameObject focalPointGameObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

        forwardInput = Input.GetAxis("Vertical");
        playerRidigbody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);

       // if (Mathf.Abs(forwardInput) <0.01f)
       // {
       //    playerRidigbody.velocity = Vector3.zero;
       // }
       // else
       // {
       //    playerRidigbody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);
       // }



    }

    private void Awake()
    {
        playerRidigbody = GetComponent<Rigidbody>();
    }



}
