using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class return_stage : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("main");
    }
}
