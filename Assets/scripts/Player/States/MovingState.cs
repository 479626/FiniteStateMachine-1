namespace Player
{
    public class MovingState : State
    {
        public MovingState(PlayerScript player, StateMachine sm) : base(player, sm)
        {
        }

        public override void Enter()
        {
            base.Enter();
            
        }

        public override void Exit()
        {
            player.xv = 0;
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            player.CheckForJump();
            player.CheckForStand();

        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}