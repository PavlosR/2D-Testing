using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float Horizontal;
    [SerializeField] private float Jump;
    [SerializeField] private float Vertical;

    private float CanDash;

    public PlayerController Controller;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        CanDash += Time.deltaTime;
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        Jump = Input.GetAxisRaw("Jump");

        if(Input.GetKeyDown("q") && CanDash >= 1f) 
        {
            Controller.Dash(Horizontal, Vertical);
            CanDash = 0f;
        }
    }

    void FixedUpdate() 
    {
        Controller.Move(Horizontal, Jump);

    }
}
