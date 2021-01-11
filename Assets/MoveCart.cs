using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float CartSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(-CartSpeed * Time.deltaTime, 0, 0);
    }
}
