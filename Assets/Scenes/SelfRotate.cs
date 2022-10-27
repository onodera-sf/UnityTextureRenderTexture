using UnityEngine;

public class SelfRotate : MonoBehaviour
{
  // 更新はフレームごとに 1 回呼び出されます
  void Update()
  {
    transform.Rotate(0, 0, 0.1f);
  }
}
