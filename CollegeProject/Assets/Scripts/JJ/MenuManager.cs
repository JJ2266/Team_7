using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Play()
    {
        //SceneManager.LoadScene(""); Load game scene
    }
    public void Quit()
    {
        Application.Quit();
    }

}
