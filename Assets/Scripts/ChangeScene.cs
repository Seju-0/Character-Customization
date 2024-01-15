using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string targetSceneName;

    public void ChangeTheScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
