using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = FindObjectOfType<LogicManagerScript>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D colission)
    {
        if(colission.tag == "Player")
            logic.AddScore();
    }
}
