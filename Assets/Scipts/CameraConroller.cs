using UnityEngine;
using UnityEngine.UI;

public class CameraConroller : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Text playerName;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        transform.position = targetPos;

        Vector3 playerNamePos = new Vector3(player.transform.position.x, player.transform.position.y + 0.8f, this.transform.position.z);
        transform.position = playerNamePos;
        // z축은 transform postion인 이유 =  2d라서 z축은 사용안하고있으므로 카메라위치로 변경해야 찍을수잇으니까
    }
    public void SetPlayerName(string name)
    {
        playerName.text = name;  // 플레이어 이름 텍스트를 업데이트
        Debug.Log(name);
    }
}