using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesManager : MonoBehaviour
{
    public void Scene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void Quit()
    {
        Application.Quit();
    } 
}
