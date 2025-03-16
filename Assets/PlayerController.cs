using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Horizontal;
    public float Jump;

    private Rigidbody2D rgdBody;
    [SerializeField] private float speed;

    private Vector2 MoveForce;
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
            MoveForce = new Vector2(Horizontal, 0.0f);
            MoveForce = MoveForce.normalized * speed;

            rgdBody.AddForce(MoveForce);
    }
}
