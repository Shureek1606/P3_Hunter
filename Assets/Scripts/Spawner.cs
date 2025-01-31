using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spider1;
    void Update()
    {
        if (Input.GetMouseButton(3))
        {
            Instantiate(spider1, transform.position, transform.rotation);
        }
    }
}
