using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlayGame (){
        SceneManager.LoadScene("Level1-1");
    }

    public void LevelSelect(){
    	SceneManager.LoadScene("LevelSelect");
    }

	public void DoQuit (){
    Debug.Log("Has quit the game!");
    Application.Quit();
    }
}
// Source: https://gist.github.com/yassineelakkazi/0d85312cfe33bb82b6b1950fc5dfcfeb
// Source: https://www.youtube.com/watch?v=WyC2VgFRArY&list=LLaSHt7dSPqCiJegcXUa8ETQ&t=59s&index=2


