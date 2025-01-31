using UnityEngine;

public class GoForward : MonoBehaviour
{
    public float goZ = 150;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * goZ * Time.deltaTime);
        Destroy(gameObject,3f);
    }
}
