using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    static GameController gameController;

    public static GameController Controller()
    {
        return gameController;
    }
    private void Awake()
    {
        if (gameController == null)
        {
            gameController = this;
        }
    }

    public string Message()
    {
        return "This is From Game Controller. It is designed using Singleton design pattern.";
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }


}
