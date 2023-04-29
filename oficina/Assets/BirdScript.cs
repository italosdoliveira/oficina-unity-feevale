using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flyForce;
    public LogicManagerScript logic;
    public AudioSource wing;
    public AudioSource hit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = FindObjectOfType<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(0f, flyForce);
            wing.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D colission){
        if(colission.transform.tag == "Obstacle"){
            logic.GameOver();
            hit.Play();
            this.enabled = false;
        }
    }
}
