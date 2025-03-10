using GameState;
using Utility;

public class InGameResultState : InGameState
{
    private InGamePresenter _inGamePresenter;

    public InGameResultState(
        InGamePresenter inGamePresenter,
        InGameStateMachine inGameStateMachine)
        : base(inGamePresenter, inGameStateMachine)
    {
        _inGamePresenter = inGamePresenter;
    }

    public override void Enter()
    {
        DebugUtility.Log("Start ResultState");

        // 結果を表示
        _inGamePresenter.ResultPresenter.ShowResult();
    }

    public override void Exit()
    {
        DebugUtility.Log("End ResultState");
    }
}
