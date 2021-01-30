using UnityEngine;
using UnityEngine.UI;

public class EndGameText : MonoBehaviour
{
    public Text UserEndName;

    public void Awake()
    {
        UserEndName.text = PlayerData.userName.endName;
    }
}
