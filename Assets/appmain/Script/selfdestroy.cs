using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestroy : MonoBehaviour
{
    //���g���j�󂳂ꂽ�Ƃ��ɓ_�������Z���������̂ł����Ă���
    [SerializeField]
    ScoreChanger scoreChanger;
    // Start is called before the first frame update
    //void //OnCollisionEnter(Collision collision)
    //{
    //�������g��j�󂷂�
    // Destroy(gameObject);
    //}
    //���������蔲�����珈�������郁�\�b�h
    // private void OnTriggerEnter(Collider other)
    // {
    //�������g��j�󂷂�
    //Destroy(gameObject);

    //�j�󂳂ꂽ�̂œ��_�����Z���鏈�����Ăяo��
    // scoreChanger.AddS;core();
    // }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ammo")
            
        {
            Debug.Log("������܂���");
            Destroy(gameObject);
            scoreChanger.AddScore();
        }


        // Update is called once per frame

    }
}
