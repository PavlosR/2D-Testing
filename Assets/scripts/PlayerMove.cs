using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float Horizontal;
    [SerializeField] private float Jump;
    [SerializeField] private float Vertical;

    [SerializeField] private float Horizontal2;
    [SerializeField] private float Vertical2;

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

            CanDash = 0f;
        }

        if(CanDash <= 0.025f && CanDash >= 0f) {

        Horizontal2 = Input.GetAxisRaw("Horizontal");
        Vertical2 = Input.GetAxisRaw("Vertical");

        } else {
            Horizontal2 = 0f;
            Vertical2 = 0f;
        }
    }

    void FixedUpdate() 
    {
        Controller.Move(Horizontal, Vertical);
        Controller.Dash(Horizontal2, Vertical2);
    }
}
