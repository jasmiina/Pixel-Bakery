using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    private static GameStateManager instance = null;

    public static GameStateManager Instance
    {
        get
        {
            if (instance == null)
            {
                DontDestroyOnLoad(instance);
                instance = new GameStateManager();
            }
            return instance;
        }

    }

    public void setScene(String scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void OnApplicationQuit()
    {
        instance = null;
    }

}