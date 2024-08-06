using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public Rigidbody2D Rigidbody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D.linearVelocityY = speed;
        }
    }
}
