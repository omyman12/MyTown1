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
       
    }

    public void InputName()
    {
        playerName = playerNameInput.text;

        if (playerName.Length > 1 && playerName.Length < 11)
        {
            GameManager.instance.SettingPlayerName(playerName);
            Debug.Log(playerName);

            controller.SetPlayerName(playerName);
            gameObject.SetActive(false);
        }

    }

}