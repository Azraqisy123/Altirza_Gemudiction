using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public AudioSource source;
    public AudioClip dieClip;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap")) //kondisi kalah kena trap
        {
            Die();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death"); // animasi death
        source.PlayOneShot(dieClip);
        StartCoroutine(LoseScreen());
    }

    IEnumerator LoseScreen()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("LoseGameScene");   
=======
        
    }

}