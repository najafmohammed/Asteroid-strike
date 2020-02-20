using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAnim : MonoBehaviour
{
    public float delta=5.0f;
    public float speed=1f;
    private Vector3 startpos;
    void Start()
    {
        startpos=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v=startpos;
        v.z+=delta * Mathf.Sin(Time.time*speed);
        transform.position=v;
    }
}
