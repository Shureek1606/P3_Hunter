using UnityEngine;

public class Spawner8 : MonoBehaviour
{
    public GameObject bullet2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullet2, transform.position, transform.rotation);


        }
    }
}
