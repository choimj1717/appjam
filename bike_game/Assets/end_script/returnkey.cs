using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnkey : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("ingame");
    }
}
