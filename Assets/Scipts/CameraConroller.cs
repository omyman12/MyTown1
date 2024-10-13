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
        // z���� transform postion�� ���� =  2d�� z���� �����ϰ������Ƿ� ī�޶���ġ�� �����ؾ� �����������ϱ�
    }
    public void SetPlayerName(string name)
    {
        playerName.text = name;  // �÷��̾� �̸� �ؽ�Ʈ�� ������Ʈ
        Debug.Log(name);
    }
}