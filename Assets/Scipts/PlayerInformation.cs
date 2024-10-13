using UnityEngine.UI;
using UnityEngine;
using System;

public class PlayerInformation : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    [SerializeField] CameraConroller controller;

    string playerName = null;
    public void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }
    public void Start()
    {

    }
    public void Update()
    {
        //Å°º¸µå
        if (playerName.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    public void InputName()
    {
        playerName = playerNameInput.text;

        if (playerName.Length > 0 && playerName.Length < 11)
        {
            GameManager.instance.SettingPlayerName(playerName);
            Debug.Log(playerName);

            controller.SetPlayerName(playerName);
        }
    }

}