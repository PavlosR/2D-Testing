using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Horizontal;
    public float Jump;

    private Rigidbody2D rgdBody;

    [Range(0, .3f)][SerializeField] private float MovementSmoothing = .05f;
    [SerializeField] private float speed;
    [SerializeField] private float Jumper = 5f;
    [SerializeField] private float DashStrength;

    private Vector3 MoveForce;
    private Vector3 Velocity = Vector3.zero;
    private Vector2 JumpForce;
    private Vector2 DashForce;
    // Start is called before the first frame update
    void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float Horizontal, float Jump) 
    {
        MoveForce = new Vector2(Horizontal * speed, 0f);
        JumpForce = new Vector2(0.0f, Jump * Jumper);



        // /MoveForce = MoveForce.normalized * speed;



        rgdBody.velocity = Vector3.SmoothDamp(rgdBody.velocity, MoveForce, ref Velocity, MovementSmoothing);
        rgdBody.AddForce(JumpForce);

    }

    public void Dash(float Horizontal, float Vertical) 
    {
        rgdBody.velocity = Vector2.zero;
        DashForce = new Vector2(Horizontal, Vertical);
        DashForce = DashForce.normalized * DashStrength;
        rgdBody.AddForce(DashForce);
    }
}
