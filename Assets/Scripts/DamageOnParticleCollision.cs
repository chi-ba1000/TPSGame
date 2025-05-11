using UnityEngine;
using System.Collections.Generic;

public class DamageOnParticleCollision : MonoBehaviour
{
    // ダメージを与える対象のタグ
    public string targetTag = "Enemy";
    // 与えるダメージ量
    public int damageAmount = 10;

    void OnParticleTrigger()
    {
        // パーティクル システムの参照を取得する
        ParticleSystem ps = GetComponent<ParticleSystem>();

        // パーティクルの情報を格納する List を作成する
        List<ParticleSystem.Particle> particles = new List<ParticleSystem.Particle>();

        // パーティクルの情報を取得する
        int numParticles = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, particles);

        // 最初のパーティクルの座標を取得する
        if (numParticles > 0)
        {
            Vector3 firstParticlePosition = particles[0].position;
            // 最初のパーティクルの座標をデバッグで出力する
            Debug.Log($"First Particle: Position = {firstParticlePosition}");
        }
    }
}
