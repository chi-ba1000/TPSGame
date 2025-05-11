using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // ダメージを与える対象のタグ
    public string targetTag = "Enemy";

    // パーティクルシステムへの参照
    private new ParticleSystem particleSystem;

    void Start()
    {
        // パーティクルシステムへの参照を取得
        particleSystem = GetComponent<ParticleSystem>();
    }

    // パーティクルが衝突したときに呼び出されるメソッド
    void OnParticleCollision(GameObject other)
    {
        // 衝突したオブジェクトが指定されたタグを持っているか確認
        if (other.CompareTag(targetTag))
        {
            Debug.Log("指定されたタグを持つオブジェクトがパーティクルに当たりました。");

            // 衝突したオブジェクトに Health コンポーネントがアタッチされているか確認
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                // ダメージを与える
                health.TakeDamage(10); // 10 はダメージ量を表す数値です
            }
        }
    }
}
