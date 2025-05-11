using UnityEngine;
using UnityEngine.UI;

public class GameClearAndReset : MonoBehaviour
{
    public Text gameClearText;
    public Text resetmenue;
    public KillCounter killCounter;
    public int maxkills;

    private void Start()
    {
        if (gameClearText != null)
        {
            gameClearText.gameObject.SetActive(false);
        }

        if (resetmenue != null)
        {
            resetmenue.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        // killCount�̒l���Ď����A����̒l�ɂȂ�����e�L�X�g�ƃ{�^����\������
        if (killCounter != null && killCounter.KillCount >= maxkills)
        {
            ShowGameClearUI();
        }
    }

    private void ShowGameClearUI()
    {
        if (gameClearText != null)
        {
            gameClearText.gameObject.SetActive(true);
        }

        if (resetmenue != null)
        {
            resetmenue.gameObject.SetActive(true);
        }
    }
}
