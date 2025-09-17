using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on this GameObject.");
            enabled = false;
        }
    }

    void Update()
    {
       
       

       
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * z + transform.right * x;
        moveDirection = moveDirection.normalized * moveSpeed;

      
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

       
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
