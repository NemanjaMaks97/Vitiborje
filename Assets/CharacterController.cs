using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public Rigidbody Rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.linearVelocity = new Vector3(0, speed, 0 );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
