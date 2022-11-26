using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput = null;
    
    private BaseCharacterAction playerAction = new PlayerAction();

    private PlayerStatus playerStatus = new PlayerStatus();

    public void DoPlayerAction(int trunNum)
    {
        playerAction.CharacterAction(playerStatus.CharacterStatusChange(playerInput.GetInputCommand(trunNum)));
    }
}
