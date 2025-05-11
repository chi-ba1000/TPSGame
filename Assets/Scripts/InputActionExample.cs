using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading;


public class InputActionExample : MonoBehaviour
{
    public Animator animator;
    // Actionをインスペクターから編集できるようにする
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

        //ONOFFの値取得
        bool isOn = animator.GetBool("ONOFF");

        if (value == 1)
        {

            if(isOn == false) 
            {
                animator.SetBool("ONOFF", true);
            }

            else if(isOn == true)
            {
                animator.SetBool("ONOFF", false);
            }
            
            Thread.Sleep(200);
        }
        // 入力値をログ出力
        Debug.Log($"Actionの入力値 : {value}");
        Debug.Log($"現在の状態 : {animator.GetBool("ONOFF")}");
    }
}