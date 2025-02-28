using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject bullet1;
    void Update()
    {

        Instantiate(bullet1, transform.position, transform.rotation);
 
    }
}
