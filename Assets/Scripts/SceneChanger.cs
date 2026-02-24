using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        StartCoroutine(LoadSceneWithDelay(sceneName));
    }

    private System.Collections.IEnumerator LoadSceneWithDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        StartCoroutine(QuitWithDelay());
    }

    private System.Collections.IEnumerator QuitWithDelay()
    {
        yield return new WaitForSeconds(0.4f);

   
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}