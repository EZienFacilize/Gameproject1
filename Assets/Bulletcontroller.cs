using UnityEngine;
using System.Collections;

public class Bulletcontroller : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.2f, 0, 0);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        //衝突時にスコアを更新する
        GameObject.Find("Canvas").GetComponent<Scorecontoroller>().Addscore();



        //弾道を破棄
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }


}
