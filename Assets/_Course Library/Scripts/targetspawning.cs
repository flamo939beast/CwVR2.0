using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetspawning : MonoBehaviour
{
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Target, new Vector3(Random.Range(6.0f, 10.0f), Random.Range(1.0f, 2.0f), Random.Range(2.0f, 2.025f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
