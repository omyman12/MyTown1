using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string playerName;
    public int characterIndex = 0;

    private GameObject kngiht;
    private GameObject dwarf;


    public static GameManager instance = null;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy (instance);
    }
    public void SettingPlayerName(string playerName)
    {
        playerName = name;
    }

    public string returnPlayerName()
    {
        return playerName;
    }
    public void Start()
    {
        Initalize();
        // SettingPlayerName(playerName); 
        InvokeCharacter(); 
       
    }

    public void KnightChoice()
    {
        characterIndex = 1;
    }

    public void DwarfChoice()
    {
        characterIndex = 0;
    }
    public void Initalize()
    {
        kngiht = Resources.Load<GameObject>("Prefabs/knight");
        dwarf = Resources.Load<GameObject>("Prefabs/dwarf");

        if (kngiht == null)
            Debug.LogError("Knight prefab errer");
        if (dwarf == null)
            Debug.LogError("Dwarf prefab errer");
    }

    public void InvokeCharacter() 
    {
        if (characterIndex == 0)
        {
            Instantiate(dwarf, this.transform);
        }
        else if (characterIndex == 1)
        {
            Instantiate(kngiht, this.transform);
        }
    }

}