using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading;


public class InputActionExample : MonoBehaviour
{
    public Animator animator;
    // Action���C���X�y�N�^�[����ҏW�ł���悤�ɂ���
    [SerializeField] private InputAction _action;

    // �L����
    private void OnEnable()
    {
        // InputAction��L����
        // ��������Ȃ��Ɠ��͂��󂯎��Ȃ����Ƃɒ���
        _action?.Enable();
    }

    // ������
    private void OnDisable()
    {
        // ���g�������������^�C�~���O�Ȃǂ�
        // Action�𖳌�������K�v������
        _action?.Disable();
    }

    public void Update()
    {
        if (_action == null) return;

        // Action�̓��͒l��ǂݍ���
        var value = _action.ReadValue<float>();

        //ONOFF�̒l�擾
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
        // ���͒l�����O�o��
        Debug.Log($"Action�̓��͒l : {value}");
        Debug.Log($"���݂̏�� : {animator.GetBool("ONOFF")}");
    }
}