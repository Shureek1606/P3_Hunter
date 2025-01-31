using UnityEngine;

public class CameraRotation : MonoBehaviour
{


    public float rotateX = 60;
    public float rotateY = 60;


    public float vert;
    public float horiz;
 

    void Update()
    {
        vert = Input.GetAxis("Vertical"); 
        horiz = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * rotateX * Time.deltaTime * horiz);

        transform.Rotate(Vector3.back * rotateY * Time.deltaTime * vert);

    }
}