using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSide : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        Transform trans = other.gameObject.transform;
        trans.position = new Vector3((-trans.position.x)/0.95f, trans.position.y, 0f);
    }
}
