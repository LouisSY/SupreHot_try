using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 300f, 0f) * Time.deltaTime, Space.World);
    }
}
