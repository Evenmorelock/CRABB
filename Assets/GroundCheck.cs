using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public playerController controller;

    public List<Collider> collidingWith = new List<Collider>();
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" && other.tag != "collectable")
        {
            collidingWith.Add(other);
            controller.isGrounded = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player" && other.tag != "collectable")
        {
            collidingWith.Remove(other);
            if (collidingWith.Count <= 0)
            {
                controller.isGrounded = false;
            }
        }
    }
}
