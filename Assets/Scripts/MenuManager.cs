using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void baslabtn()
    {

        
        SceneManager.LoadScene(1);
    }

    public void playerPrefsBuild()
    {
        PlayerPrefs.DeleteAll();
    }

}
