using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rot;

    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rot, 0);
    }
}
