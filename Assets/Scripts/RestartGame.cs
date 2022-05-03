using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Start ()
    {
        Cursor.visible = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Scene_2");
    }
}
