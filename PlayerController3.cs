using UnityEngine;
using System.Collections;

public class PlayerController3 : MonoBehaviour {

	public float maxSpeed = 15f, jumpForce = 2500f;
	
	[SerializeField] LayerMask whatIsGround;			
	
	Transform groundCheck;								
	float groundedRadius = 0.2f;							
	bool grounded = false;														
	Animator anim;										

	bool doubleJump = false;
	bool tripleJump = false;
	bool fourthJump = false;
	
	void Awake()
	{
		groundCheck = transform.Find("GroundCheck");
		anim = GetComponent<Animator>();
	}
	
	
	void Start () 
	{
		//myTrans = this.transform;
		//myBody = this.rigidbody2D;
	}
	
	void FixedUpdate () 
	{
		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
		anim.SetBool("Ground", grounded);
		
		// Set the vertical animation
		anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

		if (grounded)
		{
			doubleJump = false;
			tripleJump = false;
			fourthJump = false;
		}

		Move (1);

		//Works for keyboards and joysticks
		#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT
		Move (Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown ("Jump"))
			Jump (true);
		#endif
	}
	//
	//Separate Move and Jump so they can be called externally by TouchButtons
	//
	public void Move(float move)
	{
		if(grounded)
		{
			// The Speed animator parameter is set to the absolute value of the horizontal input.
			anim.SetFloat("Speed", Mathf.Abs(move));
			
			// Move the character
			rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
		}
		
		if(!grounded)
			rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
	}

	public void Jump(bool jump)//we can only jump if on the ground
	{
		if ((grounded || !doubleJump || !tripleJump || !fourthJump) && jump) {
			// Add a vertical force to the player.
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(20f, jumpForce));
			
			if (!grounded && doubleJump && tripleJump)
			{
				rigidbody2D.AddForce(new Vector2(20f, jumpForce - 3000));
				fourthJump = true;
			}
			
			if(!grounded && doubleJump)
			{
				rigidbody2D.AddForce(new Vector2(20f, jumpForce-2500));
				tripleJump = true;
			}
			
			if(!grounded) 
			{
				doubleJump = true;
			}
			
		}
	}
}
	