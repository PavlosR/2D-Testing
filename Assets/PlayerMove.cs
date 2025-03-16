using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public PlayerController Controller;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Jump = Input.GetAxisRaw("Jump");
    }

    void FixedUpdate() 
    {
        Controller.Move(Horizontal, Jump);

    }
}
