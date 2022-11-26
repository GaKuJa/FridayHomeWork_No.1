using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private List<InputField> playerInputList = new List<InputField>();

    public delegate void OnPlayerActionHandler(string inputString);

    public event OnPlayerActionHandler PlayerActionHadler;

    public string GetInputCommand(int trunNum)
    {
        return playerInputList[trunNum].text;
    }
}
