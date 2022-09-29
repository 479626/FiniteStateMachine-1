using UnityEngine;

namespace Player
{
    public class StandingState : State
    {
        public StandingState(PlayerScript player, StateMachine sm) : base(player, sm)
        {
        }

        public override void Enter()
        {
            player.xv = 0;
            base.Enter();
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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                sm.ChangeState(player.jumpingState);
            }


            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
            {
                sm.ChangeState(player.movingState);
                player.xv = 2F;
            }
            else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A))
            {
                sm.ChangeState(player.movingState);
                player.xv = -2F;
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}