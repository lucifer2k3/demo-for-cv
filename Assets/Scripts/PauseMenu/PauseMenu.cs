using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    [SerializeField]private bool isPaused=false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape)){
        if (isPaused){
            Resume();
        }
        else{
            Pause();
        }
       } 
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
        isPaused=false;
        
    }
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
        isPaused=true;
    }
    public void Setting(){

    }
    public void ExitGame(){
        Debug.Log("quit");
        Application.Quit();
    }
}
