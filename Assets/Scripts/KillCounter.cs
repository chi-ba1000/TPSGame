using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    // �L�������J�E���g����ϐ�
    private int killCount = 0;

    // �L������\�����邽�߂�UI Text �R���|�[�l���g
    public Text killCountText;

    // �G���j�󂳂ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    public void EnemyDestroyed()
    {
        // �L�����𑝂₷
        killCount++;

        // �e�L�X�g���X�V����
        UpdateKillCountText();
    }

    // �e�L�X�g���X�V���郁�\�b�h
    public void UpdateKillCountText()
    {
        // UI Text �R���|�[�l���g���A�^�b�`����Ă��邱�Ƃ��m�F���A�L������\������
        if (killCountText != null)
        {
            killCountText.text = "Kills: " + killCount.ToString();
        }
    }

    // �L�������O������擾���邽�߂̃v���p�e�B
    public int KillCount
    {
        get { return killCount; }
    }
}
