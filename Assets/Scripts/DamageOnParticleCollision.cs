using UnityEngine;
using System.Collections.Generic;

public class DamageOnParticleCollision : MonoBehaviour
{
    // �_���[�W��^����Ώۂ̃^�O
    public string targetTag = "Enemy";
    // �^����_���[�W��
    public int damageAmount = 10;

    void OnParticleTrigger()
    {
        // �p�[�e�B�N�� �V�X�e���̎Q�Ƃ��擾����
        ParticleSystem ps = GetComponent<ParticleSystem>();

        // �p�[�e�B�N���̏����i�[���� List ���쐬����
        List<ParticleSystem.Particle> particles = new List<ParticleSystem.Particle>();

        // �p�[�e�B�N���̏����擾����
        int numParticles = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, particles);

        // �ŏ��̃p�[�e�B�N���̍��W���擾����
        if (numParticles > 0)
        {
            Vector3 firstParticlePosition = particles[0].position;
            // �ŏ��̃p�[�e�B�N���̍��W���f�o�b�O�ŏo�͂���
            Debug.Log($"First Particle: Position = {firstParticlePosition}");
        }
    }
}
