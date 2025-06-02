using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLogic : MonoBehaviour
{
    private readonly string _sceneName = "Level";
    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
