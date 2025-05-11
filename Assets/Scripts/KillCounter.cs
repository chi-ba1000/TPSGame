using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    // キル数をカウントする変数
    private int killCount = 0;

    // キル数を表示するためのUI Text コンポーネント
    public Text killCountText;

    // 敵が破壊されたときに呼び出されるメソッド
    public void EnemyDestroyed()
    {
        // キル数を増やす
        killCount++;

        // テキストを更新する
        UpdateKillCountText();
    }

    // テキストを更新するメソッド
    public void UpdateKillCountText()
    {
        // UI Text コンポーネントがアタッチされていることを確認し、キル数を表示する
        if (killCountText != null)
        {
            killCountText.text = "Kills: " + killCount.ToString();
        }
    }

    // キル数を外部から取得するためのプロパティ
    public int KillCount
    {
        get { return killCount; }
    }
}
