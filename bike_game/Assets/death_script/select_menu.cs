using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select_menu : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("select_stage");
    }
}
