using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public Animator animator;
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    /*void Update ()
    {
        animator.SetFloat("exp",2);
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            animator.SetFloat("exp", 2);
            Destroy(player.gameObject);
            audioPlayer.Play();
        }
    }
}

