using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public static PlayerData userName;
    public InputField playerName;
    public string endName;

    public void Awake()
    {
        if (userName == null)
        {
            userName = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (endName != playerName.text)
        {
            endName = playerName.text;
        }
    }
}
