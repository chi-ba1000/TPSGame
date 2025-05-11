using UnityEngine;
using UnityEngine.InputSystem;

public class Firesystem : MonoBehaviour
{
    [SerializeField] private InputAction _action;
    public ParticleSystem fireParticleSystem;
    public AudioSource fireSound;
    private float timer = 0.0f;
    private float cooldown = 0.1f; // 100ミリ秒

    private void OnEnable()
    {
        _action?.Enable();
    }

    private void OnDisable()
    {
        _action?.Disable();
    }

    private void Update()
    {
        if (_action == null) return;

        var value = _action.ReadValue<float>();

        Debug.Log($"Actionの入力値 : {value}");

        if (value == 1)
        {
            // クールダウン時間の経過を確認
            if (timer >= cooldown)
            {
                // パーティクル再生
                if (fireParticleSystem != null)
                {
                    fireParticleSystem.Play();
                }

                // サウンド再生
                if (fireSound != null)
                {
                    fireSound.Play();
                }

                // タイマーリセット
                timer = 0.0f;
            }
        }

        // タイマー更新
        timer += Time.deltaTime;
    }
}
