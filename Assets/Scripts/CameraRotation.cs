using UnityEngine;

public class CameraRotation : MonoBehaviour
{


    public float rotateX = -60;
    public float rotateY = +60;


    public float vert;
    public float horiz;

    void Start()
    {
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        vert = Input.GetAxis("Mouse Y"); 
        horiz = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up * rotateX * Time.deltaTime * horiz);

        transform.Rotate(Vector3.forward * rotateY * Time.deltaTime * vert);

    }
}