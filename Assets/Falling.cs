
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 20f;

    void Update()
    {
        if (transform.position.y <= -5f)
            Destroy(gameObject);
        transform.position -= new Vector3(0,fallSpeed*Time.deltaTime,0);
    }
}
