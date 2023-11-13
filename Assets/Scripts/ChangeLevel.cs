using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public void SetNextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
