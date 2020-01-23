using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float paralax;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - paralax));
        float dist = (cam.transform.position.x * paralax);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > startpos + lenght) startpos += lenght;
        else if (temp < startpos - lenght) startpos -= lenght;
    }
}
