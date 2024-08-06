using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public List<GameObject> Obstacles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var obj = Instantiate(Obstacles[0]);
        obj.transform.position = Vector3.zero;
        obj.gameObject.SetActive(true);
        Rigidbody rigidbody = obj.GetComponent(typeof(Rigidbody)) as Rigidbody;
        rigidbody.AddForce(Vector3.left * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
