using UnityEngine;

public class Spawner7 : MonoBehaviour
{
    public GameObject bat1;
    private void Start()
    {
        InvokeRepeating("BatSpawner", 30, Random.Range(0.5f,2));
    }
    void BatSpawner()
    {
        Instantiate(bat1, new Vector3(Random.Range(-40,30),73,Random.Range(120,200)), transform.rotation);
    }
}
