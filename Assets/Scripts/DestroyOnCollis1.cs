using UnityEngine;

public class DestroyOnCollis1 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);

        }

    }

}
