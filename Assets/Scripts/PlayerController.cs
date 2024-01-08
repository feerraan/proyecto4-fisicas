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



    private bool hasPoweup;

    [SerializeField] private float powerupForce =10f;
    


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
        hasPoweup = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            hasPoweup = true;
            StartCoroutine(PowerupCountdown());
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("Enemy") && hasPoweup == true)
        {
            //El enemigo sufre un empujon alejándo del player
            Rigidbody enemyRigidbody = other.gameObject.
                GetComponent<Rigidbody>();
            Vector3 direction = (other.transform.position -
                transform.position).normalized;

            enemyRigidbody.AddForce(direction * powerupForce, ForceMode.Impulse);
        }

    }

    private IEnumerator PowerupCountdown()
    {
        //espera 6 segons
        yield return new WaitForSeconds(6);
        hasPoweup = false;
    }

}
