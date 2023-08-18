using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    public float speed;
    public PlayerHealth player;

    public bool chase = false;
    public Transform startingPoint;
    public Transform endingPoint;
    private bool isDrop = false;

    void Update()
    {

        if (chase)
        {
            Chase();
            if (!isDrop && transform.position == endingPoint.position)
            {
                isDrop = true;
                gameObject.GetComponent<AudioSource>().Play();
                ShakeCamera.Instance.Shake(5f, 0.3f);
            }
        }
    }

    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, endingPoint.position, speed * Time.deltaTime);
    }




}
