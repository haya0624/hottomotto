using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestroy : MonoBehaviour
{
    //自身が破壊されたときに点数を加算させたいのでしっておく
    [SerializeField]
    ScoreChanger scoreChanger;
    // Start is called before the first frame update
    //void //OnCollisionEnter(Collision collision)
    //{
    //自分自身を破壊する
    // Destroy(gameObject);
    //}
    //何かがすり抜けたら処理が走るメソッド
    // private void OnTriggerEnter(Collider other)
    // {
    //自分自身を破壊する
    //Destroy(gameObject);

    //破壊されたので得点を加算する処理を呼び出す
    // scoreChanger.AddS;core();
    // }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ammo")
            
        {
            Debug.Log("当たりました");
            Destroy(gameObject);
            scoreChanger.AddScore();
        }


        // Update is called once per frame

    }
}
