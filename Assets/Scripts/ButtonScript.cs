using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnterLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Freeze()
    {
        Time.timeScale = 0;
    }

    public void Unfreeze()
    {
        Time.timeScale = 1;
    }
}
