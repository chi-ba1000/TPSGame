using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // �_���[�W��^����Ώۂ̃^�O
    public string targetTag = "Enemy";

    // �p�[�e�B�N���V�X�e���ւ̎Q��
    private new ParticleSystem particleSystem;

    void Start()
    {
        // �p�[�e�B�N���V�X�e���ւ̎Q�Ƃ��擾
        particleSystem = GetComponent<ParticleSystem>();
    }

    // �p�[�e�B�N�����Փ˂����Ƃ��ɌĂяo����郁�\�b�h
    void OnParticleCollision(GameObject other)
    {
        // �Փ˂����I�u�W�F�N�g���w�肳�ꂽ�^�O�������Ă��邩�m�F
        if (other.CompareTag(targetTag))
        {
            Debug.Log("�w�肳�ꂽ�^�O�����I�u�W�F�N�g���p�[�e�B�N���ɓ�����܂����B");

            // �Փ˂����I�u�W�F�N�g�� Health �R���|�[�l���g���A�^�b�`����Ă��邩�m�F
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                // �_���[�W��^����
                health.TakeDamage(10); // 10 �̓_���[�W�ʂ�\�����l�ł�
            }
        }
    }
}
