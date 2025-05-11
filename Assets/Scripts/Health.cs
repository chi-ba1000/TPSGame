using UnityEngine;

public class Health : MonoBehaviour
{
    // �ő�̗�
    public int maxHealth = 100;
    // ���݂̗̑�
    private int currentHealth;


    // �j�󎞂ɍĐ�����T�E���h
    public AudioClip HitSound;


    // �j�󎞂ɍĐ�����T�E���h
    public AudioClip destroysound;

    // �L�������J�E���g���邽�߂̃N���X�ւ̎Q��
    public KillCounter killCounter;

    // ������
    private void Start()
    {
        currentHealth = maxHealth;
    }

    // �_���[�W���󂯂郁�\�b�h
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (HitSound != null)
        {
            AudioSource.PlayClipAtPoint(HitSound, transform.position);
        }
        Debug.Log($"�f���N�V");

        // �̗͂�0�ȉ��ɂȂ�����I�u�W�F�N�g��j�󂷂�
        if (currentHealth <= 0)
        {
            if (destroysound != null)
            {
                AudioSource.PlayClipAtPoint(destroysound, transform.position);
            }
            Destroy(gameObject);
            // �L�����𑝂₷
            if (killCounter != null)
            {
                killCounter.EnemyDestroyed();
            }
        }

    }
}
