using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    //****Create a empty game object on the unity interface called"Level Manager and attach this script.*****
    //**** This must be done to all scenes/levels.****

    //This is the level manager script
    //The first function is to load level.
    //Using buttons to load scenes

    public void LoadLevel(string name)


    {
        Debug.Log("Level Load Requested for: " + name);
        SceneManager.LoadScene(name);
    }


    //This is to quit Level.It is associated with the quit button UI. 
    public void QuitLevel()
    {
        Debug.Log("Quiting Level");
        Application.Quit();
    }
    // This is used for the startmenu of the game. Not attached to anything at the time.

    public void StartMenu()  //this creates a tag for the button
    {
        SceneManager.LoadScene("MainMenu"); //this loads a scene when in which a button is attached (String aka scene name)
    }

    //this is used for loading the first level of play. attached to a button on the UI 
    public void MainMenu()
    {
        SceneManager.LoadScene("Weave V2"); //Pressing the PlayGame button will load the game scene
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    //this allows you to load the weave v2 scene once you hit the replay button
    public void GameOver() //this is the scene
    {
        SceneManager.LoadScene("Weave V2"); // this is the replay button to load the weave scene
    }

    public void WeaveV2()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LevelBegin()
    {
        SceneManager.LoadScene("Level1-1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level1-2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level1-3");
    }

    public void TutorialI()
    {
        SceneManager.LoadScene("Level1");
    }

    public void TutorialII()
    {
        SceneManager.LoadScene("level 2");
    }

    public void TutorialIII()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void TutorialIV()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Instruction()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void WinLevel1()
    {
        SceneManager.LoadScene("Win");
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
    
    public void Lose2()
    {
        SceneManager.LoadScene("Lose2");
    }
    
    public void Lose3()
    {
        SceneManager.LoadScene("Lose3");
    }
}

