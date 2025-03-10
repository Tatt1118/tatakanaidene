using UniRx;
using UnityEngine;

public class TimerModel
{
    private ReactiveProperty<float> _countDown;
    public IReadOnlyReactiveProperty<float> CountDown => _countDown;

    private ReactiveProperty<float> _timer;
    public IReadOnlyReactiveProperty<float> Timer => _timer;

    public void Initialize()
    {
        _countDown = new ReactiveProperty<float>();
        _timer = new ReactiveProperty<float>();
    }

    /// <summary>
    /// 値の初期値を設定
    /// </summary>
    public void SetUp()
    {
        _countDown.Value = ConstantData.COUNT_DOWN;
        _timer.Value = ConstantData.TIME;
    }

    public void CountDownManualUpdate()
    {
        _countDown.Value -= Time.deltaTime;
    }

    public void TimerManualUpdate()
    {
        _timer.Value -= Time.deltaTime;
    }
}
