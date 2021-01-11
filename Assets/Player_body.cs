
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_body : MonoBehaviour
{
    private int count=0;
    public GameObject restart;
    public GameObject exit;
    public static bool lose = false;
    private void Awake()
    {
        lose = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dangerous")
        {
            lose = true;
            restart.SetActive(true);
            exit.SetActive(true);
        }

        if (collision.gameObject.tag == "PositivePoint")
        {
            if (count != 7)
                count++;
            else
            SceneManager.LoadScene("Finish");
            
            
        }
    }
}
