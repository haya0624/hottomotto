using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    { }

    void Update()
    { }

    private void OnCollisionEnter(Collision collision) //�Ԃ�����������閽�ߕ��J�n
    {
        if (collision.gameObject.CompareTag("Enemy"))//����������Tagutukeru�Ƃ����^�O������I�u�W�F�N�g����Ł`�Ƃ��������̉�
        {
            Destroy(gameObject);//���̃Q�[���I�u�W�F�N�g�����ł�����
        }
    }
}