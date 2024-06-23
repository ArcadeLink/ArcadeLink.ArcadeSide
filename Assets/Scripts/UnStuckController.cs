using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnStuckController : MonoBehaviour
{
    private float _escapeTimer = 0f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _escapeTimer += Time.deltaTime;
            if (_escapeTimer > 2f)
            {
                // 强制重置场景
                ResetScene();
            }
        }
        else
        {
            _escapeTimer = 0f;
        }
    }

    private void ResetScene()
    {
        Destroy(GameObject.Find("DebugConsole"));
        Destroy(GameObject.Find("Main Camera"));
        SceneManager.LoadScene("Setup Scene");
    }
}
