using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject bullet1;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet1, transform.position, transform.rotation);

            
        }
    }
}
