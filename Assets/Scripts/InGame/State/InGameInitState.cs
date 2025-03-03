using Utility;

namespace GameState
{
    public class InGameInitState : InGameState
    {
        private InGamePresenter _inGamePresenter;
        private InGameStateMachine _stateMachine;

        public InGameInitState(
            InGamePresenter inGamePresenter,
            InGameStateMachine inGameStateMachine)
            : base(inGamePresenter, inGameStateMachine)
        {
            _inGamePresenter = inGamePresenter;
            _stateMachine = inGameStateMachine;
        }

        public override void Enter()
        {
            DebugUtility.Log("Start InitState");
            _inGamePresenter.TimerPresenter.Initialize();

            // StartState��
            _stateMachine.ChangeState(_inGamePresenter.InGameStartState);
        }

        public override void Exit()
        {
            DebugUtility.Log("End InitState");
        }
    }
}


