using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class SceneLoadHandler : MonoBehaviour
{
    [HideInInspector] public int SceneLoadDelay = 0;

    public void LoadScene(int sceneIndex) => SceneManager.LoadScene(sceneIndex);

    public void SetSceneLoadDelay(int targetDelay) => SceneLoadDelay = targetDelay;

    public void LoadSceneWithDelay(int sceneIndex) => StartCoroutine(SceneLoadWithDelay(sceneIndex));

    private IEnumerator SceneLoadWithDelay(int sceneIndex) {
        yield return new WaitForSeconds(SceneLoadDelay); LoadScene(sceneIndex);
    }
}
