using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spider1;
    private void Start()
    {
        InvokeRepeating("SpiderSpawner", 10, 0.5f);
    }


    void SpiderSpawner()
    {
        Instantiate(spider1, transform.position, transform.rotation);
    }
    
}
