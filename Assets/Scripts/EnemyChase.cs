using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // プレイヤーのTransform
    public float moveSpeed = 5f; // 敵の移動速度

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (player != null)
        {
            // プレイヤーの方向に向かって移動
            Vector3 direction = (player.position - transform.position).normalized;
            rb.velocity = direction * moveSpeed;
        }
    }
}
