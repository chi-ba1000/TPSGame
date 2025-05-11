using UnityEngine;

public class ToggleAnimationOnRightClick : MonoBehaviour
{
    public Animator animator;
    public string animationParameter; // アニメーションのパラメーター名（ブール値）

    private bool isAnimationOn = false;

    void Start()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ToggleAnimation();
        }
    }

    void ToggleAnimation()
    {
        // アニメーションの状態を反転させる
        isAnimationOn = !isAnimationOn;

        // アニメーションの状態に応じてアニメーションを再生または停止する
        animator.SetBool(animationParameter, isAnimationOn);
    }
}
