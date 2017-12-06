
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //this is a collision script for winning the game, the script is attached to an invisible cube at the end of the track

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        gameHasEnded = true;
        Debug.Log("Game Over");
        Invoke("Restart", restartDelay);
    }


   void Restart()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }



}