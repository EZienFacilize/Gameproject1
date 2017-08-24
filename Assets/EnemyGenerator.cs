using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject Enemyprefub;

    void Start()
    {
        InvokeRepeating("GenEnemy", 1, 1);
    }

    void GenEnemy()
    {
        Instantiate(Enemyprefub, new Vector3(6, -2.5f + 5 * Random.value, 0), Quaternion.identity);
    }
}