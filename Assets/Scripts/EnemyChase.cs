using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // �v���C���[��Transform
    public float moveSpeed = 5f; // �G�̈ړ����x

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (player != null)
        {
            // �v���C���[�̕����Ɍ������Ĉړ�
            Vector3 direction = (player.position - transform.position).normalized;
            rb.velocity = direction * moveSpeed;
        }
    }
}
