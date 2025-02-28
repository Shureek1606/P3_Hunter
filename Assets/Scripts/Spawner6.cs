using UnityEngine;

public class Spawner6 : MonoBehaviour
{
    public GameObject bullet6;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet6, transform.position, transform.rotation);

            
        }
    }
}
