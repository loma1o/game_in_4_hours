
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_body : MonoBehaviour
{
    private int count=5;
    public Text txt;
    public GameObject restart;
    public GameObject exit;
    public GameObject music;
    public static bool lose = false;
    private void Awake()
    {
        if (!GameObject.Find("Music(Clone)"))
            Instantiate(music);
        lose = false;
    }

    private void Update()
    {
        txt.text = count.ToString();
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
            if (count != 0)
            {
                count--;
                collision.gameObject.tag = "Untagged";
                collision.gameObject.SetActive(false);
            }
            else
                SceneManager.LoadScene("Finish");
            
            
        }
    }
}
