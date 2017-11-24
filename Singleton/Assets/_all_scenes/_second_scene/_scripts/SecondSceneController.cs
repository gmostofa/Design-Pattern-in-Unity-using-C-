using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSceneController : MonoBehaviour
{

    public Text textMessage;

    void Start()
    {
        textMessage.text = GameController.Controller().Message();
    }


}
