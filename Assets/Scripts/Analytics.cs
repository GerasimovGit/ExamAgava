using Hero;
using Level;
using UnityEngine;

public class Analytics : MonoBehaviour
{
    [SerializeField] private LevelHolder _levelHolder;
    [SerializeField] private PlayerWallet _playerWallet;

    private void OnEnable()
    {
        _levelHolder.LevelCompleted += OnLevelCompleted;
        _playerWallet.MoneyChanged += OnChangeMoney;
    }

    private void OnDisable()
    {
        _levelHolder.LevelCompleted -= OnLevelCompleted;
        _playerWallet.MoneyChanged -= OnChangeMoney;
    }

    public void OnLevelCompleted()
    {
        print("�� ��������� �����, �������, ��� ��� ������� �����, ���, �� ���� �������� � ���� ����");
    }

    public void OnChangeMoney(int money)
    {
        print("����� ����� ��-��");
    }
}