using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Sensitivity")]
    public float mouseSensitivity = 100f;

    private float xRotation = 0f;

    void Start()
    {
       
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
       
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevent looking too far up or down


        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        transform.Rotate(Vector3.up * mouseX);
    }
}
