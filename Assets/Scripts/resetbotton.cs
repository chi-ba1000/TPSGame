using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class resetbotton : MonoBehaviour
{
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

        if (value == 1)
        {
            Debug.Log($"�҂��");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        // ���͒l�����O�o��
        Debug.Log($"���Z�b�g���܂���");
    }
}