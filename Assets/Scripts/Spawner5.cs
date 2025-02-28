using UnityEngine;

public class Spawner5 : MonoBehaviour
{
    public GameObject bullet5;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet5, transform.position, transform.rotation);

            
        }
    }
}
