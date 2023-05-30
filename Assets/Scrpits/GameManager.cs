
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CubeRunner
{
    public class GameManager : MonoBehaviour
    {
        public bool gameHasEnded = false;
        public float restartDelay = 2f;
        public GameObject completeLevelUI;


        public void EndGame()
        {
            if (!gameHasEnded)
            {
                gameHasEnded = true;

                Invoke("Restart", restartDelay);
            }
        }
        public void Restart() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public void CompleteLevel()
        {
            completeLevelUI.SetActive(true);
        }
        public void Replay()
        {
            SceneManager.LoadScene("level01");
        }
        public void QuitGame()
        {
            Application.Quit();
        }
        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}