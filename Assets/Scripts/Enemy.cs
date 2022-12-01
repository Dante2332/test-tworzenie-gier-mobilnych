using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 4f;
    Transform target;

    private void Update()
    {
       if (target != null)
        {
            float enemyMove = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, enemyMove);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
            Debug.Log(target);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
        }
    }
}
