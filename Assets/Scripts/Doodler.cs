using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodler : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h*moveSpeed, rb.velocity.y);

        if(h != 0)
        {
            transform.localScale = new Vector3(-h, 1, 1);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("MainCamera"))
        {
            Debug.Log("屏幕外");
            Debug.Log(transform.position.y);
            Debug.Log(Camera.main.transform.position.y);
            if(transform.position.y < Camera.main.transform.position.y - 5)
            {
                Debug.Log("游戏结束");
                GameManager.Instance.GameOver();
            }
        }
    }
}