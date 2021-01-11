using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_knifes : MonoBehaviour
{
    public GameObject star;
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(SpawnStar());
    }

    IEnumerator Spawn()
    {
        while (!Player_body.lose)
        {
            Instantiate(knife, new Vector2(Random.Range(-8.5f, 8.5f),6.6f),Quaternion.Euler(0,0,-90));
            yield return new WaitForSeconds(0.7f);
        }
    }
    IEnumerator SpawnStar()
    {
        while (!Player_body.lose)
        {
            Instantiate(star, new Vector2(Random.Range(-8.5f, 8.5f), 6.6f), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
        }
    }
}
