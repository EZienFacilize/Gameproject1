using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
       
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        Destroy(coll.gameObject);
            Destroy(gameObject);
        Debug.Log("通った");

    }
    }