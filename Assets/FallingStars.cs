
using UnityEngine;

public class FallingStars : MonoBehaviour
{
    [SerializeField]
    private float fallStarSpeed = 40f;

    void Update()
    {
        if (transform.position.y <= -5f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallStarSpeed * Time.deltaTime, 0);
    }
}
