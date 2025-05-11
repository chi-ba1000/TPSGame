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
        // killCountの値を監視し、特定の値になったらテキストとボタンを表示する
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
