using UnityEngine;

namespace Player
{
    public class JumpingState : State
    {
        public JumpingState(PlayerScript player, StateMachine sm) : base(player, sm)
        {
        }

        public override void Enter()
        {
            base.Enter();
            sm.ChangeState(player.standingState);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) sm.ChangeState(player.movingState);
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}