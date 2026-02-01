using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject objetoMenuPausa;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        objetoMenuPausa.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Continue()
    {
        objetoMenuPausa.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("prueba");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}