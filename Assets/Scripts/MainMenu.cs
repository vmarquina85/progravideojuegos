using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //StartGame();
    }

    public void StartGame()
    {
        StartCoroutine(CargarNivel(1));
    }

    public void Instrucciones()
    {
        //SceneManager.LoadScene();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator CargarNivel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
