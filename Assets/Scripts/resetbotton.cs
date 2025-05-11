using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class resetbotton : MonoBehaviour
{
    [SerializeField] private InputAction _action;

    // 有効化
    private void OnEnable()
    {
        // InputActionを有効化
        // これをしないと入力を受け取れないことに注意
        _action?.Enable();
    }

    // 無効化
    private void OnDisable()
    {
        // 自身が無効化されるタイミングなどで
        // Actionを無効化する必要がある
        _action?.Disable();
    }

    public void Update()
    {
        if (_action == null) return;

        // Actionの入力値を読み込む
        var value = _action.ReadValue<float>();

        if (value == 1)
        {
            Debug.Log($"ぴよん");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        // 入力値をログ出力
        Debug.Log($"リセットしました");
    }
}