using UnityEngine;

public class SelfRotate : MonoBehaviour
{
  // �X�V�̓t���[�����Ƃ� 1 ��Ăяo����܂�
  void Update()
  {
    transform.Rotate(0, 0, 0.1f);
  }
}
