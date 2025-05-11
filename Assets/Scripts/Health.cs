using UnityEngine;

public class Health : MonoBehaviour
{
    // 最大体力
    public int maxHealth = 100;
    // 現在の体力
    private int currentHealth;


    // 破壊時に再生するサウンド
    public AudioClip HitSound;


    // 破壊時に再生するサウンド
    public AudioClip destroysound;

    // キル数をカウントするためのクラスへの参照
    public KillCounter killCounter;

    // 初期化
    private void Start()
    {
        currentHealth = maxHealth;
    }

    // ダメージを受けるメソッド
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (HitSound != null)
        {
            AudioSource.PlayClipAtPoint(HitSound, transform.position);
        }
        Debug.Log($"デュクシ");

        // 体力が0以下になったらオブジェクトを破壊する
        if (currentHealth <= 0)
        {
            if (destroysound != null)
            {
                AudioSource.PlayClipAtPoint(destroysound, transform.position);
            }
            Destroy(gameObject);
            // キル数を増やす
            if (killCounter != null)
            {
                killCounter.EnemyDestroyed();
            }
        }

    }
}
