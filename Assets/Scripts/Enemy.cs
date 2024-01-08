using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody enemyRigidbody;
    [SerializeField] private float speed = 5f;
    private GameObject player;

    // Start is called before the first frame updates

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction = direction.normalized;
        enemyRigidbody.AddForce(direction * speed);

    }

    private void Awake()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        player = GameObject.Find("Player");
    }
}
