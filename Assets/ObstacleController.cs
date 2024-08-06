using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void OnEnable()
    {
        //gameObject.transform.position = Vector3.zero;
        Rigidbody rigidbody = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
        rigidbody.AddForce(Vector3.left * speed);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //var obj = Instantiate(Obstacles[0]);
        //obj.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
