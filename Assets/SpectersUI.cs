using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectersUI : MonoBehaviour
{
    private bool active = false;

    private void Nothing()
    {
        return;
    }
    public void ChangeAbility()
    {
        Debug.Log(active);
        if (active)
        {
            active = false;
            Gamehandler.changeActionButton(() => Nothing());
        }
        else if (!active&&gameObject.name.Equals("GravitySpecter"))
        {
            active = true;
            Gamehandler.changeActionButton(() => CharacterMovement.invertGravity());
        }
        PlayerInfo.ChangeSking(GetComponent<SpriteRenderer>(),active);
    }


}
