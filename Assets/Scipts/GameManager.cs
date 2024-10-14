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
            Destroy(instance);
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
        TimeStop();
    }

    public void KnightChoice()
    {

        //gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        characterIndex = 1;
        Debug.Log("idx 1");
        if (characterIndex == 1)
        {
            //GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Debug.Log("idx 1 색변경");
        }
        //else GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        var image = GetComponent<Image>();
        if (image == null)
        {
            Debug.LogError("Image missing"); // 이미지가 없음 > 왜?
        }
        else
        {
            image.color = new Color32(0, 0, 0, 255);
        }


    }

    public void DwarfChoice()
    {

        //GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        characterIndex = 0;
        Debug.Log("idx 0");
        if (characterIndex == 0)
        {
            //GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Debug.Log("idx 0 색변경");
        }
        //GetComponent<Image>().color = new Color32(0, 0, 0, 255);
    }
    public void Initalize()
    {
        kngiht = Resources.Load<GameObject>("Prefabs/knight");
        dwarf = Resources.Load<GameObject>("Prefabs/dwarf");
       
    }

    public void TimeStop()
    {
        Time.timeScale = 0.0f;
    }
    public void TimePass()
    {
        Time.timeScale = 1.0f;
    }
    public void InvokeCharacter()
    {
        if (characterIndex == 0)
        {
            Instantiate(dwarf, this.transform); //this.transform을 해야 지정된 위치로 프리팹
        }
        else if (characterIndex == 1)
        {
            Instantiate(kngiht, this.transform);
        }
    }

}