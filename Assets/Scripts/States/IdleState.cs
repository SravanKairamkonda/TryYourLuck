using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CardBaseState
{
    public override void OnStart(CardStateManager cardStateManager)
    {
        cardStateManager._mainButtonText.text = "Reveal";
        cardStateManager.BlankCardsText();
        cardStateManager.DefaultCardData();
        cardStateManager.ButtonsInteractivity(false);
        cardStateManager.MainButtonInteractivity(true);


        debug.Log(cardStateManager.currentState.ToString());
    }

    public override void OnButtonEvent(CardStateManager cardStateManager)
    {
        cardStateManager.SwitchState(cardStateManager.revealState);
    }
}
