using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // karaktere z ekseni yönünde(ileri doðru) belirli bir hýzda hareket verdik 

        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y,
            transform.position.z + runningSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
