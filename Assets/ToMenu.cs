using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Menu");
    }
}
