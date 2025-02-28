using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject bullet2;
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            Instantiate(bullet2, transform.position, transform.rotation);

            
        }
    }
}
