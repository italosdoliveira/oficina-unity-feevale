using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spanwRate;
    public float timer;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        SpanwPipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spanwRate){
            SpanwPipe();
            timer = 0;
        }
    }

    void SpanwPipe(){
        float lowestPoint = transform.position.y - offset;
        float highestPoint = transform.position.y + offset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0f), transform.rotation);
    }
}
