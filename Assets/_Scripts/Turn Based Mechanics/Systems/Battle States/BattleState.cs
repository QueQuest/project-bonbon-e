using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BattleStateMachine {
    public abstract class BattleState : State<BattleStateMachine, BattleState, BattleStateInput> {

        public virtual void EnterBattle() { MySM.Transition<TurnState>(); }

        public virtual void AnimateTurn() { MySM.Transition<AnimateState>(); }
    }
}
