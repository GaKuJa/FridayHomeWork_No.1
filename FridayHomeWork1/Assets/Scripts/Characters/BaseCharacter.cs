using UnityEngine;

public abstract class BaseCharacter
{
    public enum CharacterStatus
    {
        Idol,
        Job,
        Defense,
        Heal
    }
}

public abstract class BaseCharacterAction : MonoBehaviour
{
    public delegate void OnCharacterViewHandler();

    public event OnCharacterViewHandler CharacterViewHandler;
    
    public void CharacterAction(BaseCharacter.CharacterStatus characterStatus)
    {
        switch (characterStatus)
        {
            case BaseCharacter.CharacterStatus.Idol:
                ActionIdol();
                break;
            case BaseCharacter.CharacterStatus.Job:
                ActionJob();
                break;
            case BaseCharacter.CharacterStatus.Defense:
                ActionDefense();
                break;
            case BaseCharacter.CharacterStatus.Heal:
                ActionHeal();
                break;
            default:
                Debug.LogError("Enumに当てはまらない値が来ました");
                break;
        }
        CharacterViewHandler?.Invoke();   
    }

    public void ActionJob()
    {
        Debug.Log("Action Job!");
    }

    public void ActionDefense()
    {
        Debug.Log("Action Defense!");
    }

    public void ActionHeal()
    {
        Debug.Log("Action Heal!");
    }

    public void ActionIdol()
    {
        Debug.Log("Don't Action!");
    }
}