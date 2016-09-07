using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public GameObject hero;
    public Camera[] cam;
    public bool grounded;
    public Transform GroundCheck;
    public float GroundedRadius = .3f;
    public LayerMask WhatIsGround;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cam[1].enabled = !cam[1].enabled;
            cam[0].enabled = !cam[0].enabled;
            hero.SetActive(true);
            gameObject.SetActive(false);
        }
        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move*CreateCharacter.Agi, GetComponent<Rigidbody2D>().velocity.y);

        grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundedRadius, WhatIsGround);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jump();
        }
    }

    public void jump()
    {


        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 700f));

    }
}
