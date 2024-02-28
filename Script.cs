using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int playerHealth
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D;
        
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Hello, I'm here.");
        
    }

    void Awake()
    {
        playerHealth = 100;
        Debug.Log(playerHealth);
    }

    void FixedUpdate()
    {

    }
}