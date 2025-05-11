using UnityEngine;

public class ToggleAnimationOnRightClick : MonoBehaviour
{
    public Animator animator;
    public string animationParameter; // �A�j���[�V�����̃p�����[�^�[���i�u�[���l�j

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
        // �A�j���[�V�����̏�Ԃ𔽓]������
        isAnimationOn = !isAnimationOn;

        // �A�j���[�V�����̏�Ԃɉ����ăA�j���[�V�������Đ��܂��͒�~����
        animator.SetBool(animationParameter, isAnimationOn);
    }
}
