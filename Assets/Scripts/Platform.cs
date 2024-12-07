using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlatformType
{
    Normal,
    Weak
}

public class Platform : MonoBehaviour
{
    public PlatformType platformType;
    public float bounceSpeed = 9f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal == Vector2.down)//与Platform碰撞的物体的第一个接触点的法向量向下
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                rb.velocity = Vector2.up * bounceSpeed;
            }

            if(platformType == PlatformType.Weak)
            {
                if(GetComponent<Animator>() != null)
                {
                    GetComponent<Animator>().SetTrigger("Trigger");
                    Invoke("HideGameObject", 0.4f);
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("MainCamera"))
        {
            gameObject.SetActive(false);
        }
    }

    void HideGameObject()
    {
        gameObject.SetActive(false);
    }
}
