using System;
using UnityEngine;

public class PlayerStatus : BaseCharacter
{
    public CharacterStatus CharacterStatus = CharacterStatus.Idol;

    public CharacterStatus CharacterStatusChange(string inputString)
    {
        foreach (CharacterStatus Value in Enum.GetValues(typeof(CharacterStatus)))
        {
            if (inputString == Enum.GetName(typeof(CharacterStatus), Value))
            {
                CharacterStatus = Value;
                break;
            }
            else
            {
                CharacterStatus = CharacterStatus.Idol;
            }
        }

        return CharacterStatus;
    }
}
