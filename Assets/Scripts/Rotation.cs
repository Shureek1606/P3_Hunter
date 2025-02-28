using UnityEngine;

public class Rotation : MonoBehaviour
{


    void Update()
    {
        RotateObject();
    }
    void RotateObject()
    {
        int speedRotate = 360;
        transform.Rotate(Vector3.back * Time.deltaTime * speedRotate);
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotate);
    }
}
