using UnityEngine;
using System.Collections;

public class PlatformerCharacter2D : MonoBehaviour 
{
	//bool facingRight = true;							// For determining which way the player is currently facing.

	[SerializeField] float maxSpeed = 15f;				// The fastest the player can travel in the x axis.
	[SerializeField] float jumpForce = 2500f;			// Amount of force added when the player jumps.			
				
	[SerializeField] LayerMask whatIsGround;			// A mask determining what is ground to the character
	[SerializeField] LayerMask whatIsFire;
	[SerializeField] LayerMask whatIsElectricity;


	public Transform groundCheck;								// A position marking where to check if the player is grounded.
	public float groundedRadius = 0.2f;							// Radius of the overlap circle to determine if grounded
	public bool grounded = false;								// Whether or not the player is grounded.
	public Transform fireCheck;
	public float fireRadius = 1f;
	public bool onFire = false;
	public Transform electricityCheck;
	public float electricityRadius = 2f;
	public bool shock = false;

	//Transform ceilingCheck;								// A position marking where to check for ceilings
	//float ceilingRadius = .01f;							// Radius of the overlap circle to determine if the player can stand up
	Animator anim;										// Reference to the player's animator component.

	bool doubleJump = false;
	bool tripleJump = false;
	bool fourthJump = false;

    void Awake()
	{
		//Setting up references.
		groundCheck = transform.Find("GroundCheck");
		fireCheck = transform.Find ("FireCheck");
		electricityCheck = transform.Find ("ElectricityCheck");
		//ceilingCheck = transform.Find("CeilingCheck");
		anim = GetComponent<Animator>();
	}

	void Start()
	{
		audio.volume = 0;
	}

	void FixedUpdate()
	{
		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
		anim.SetBool("Ground", grounded);

		onFire = Physics2D.OverlapCircle(fireCheck.position, fireRadius, whatIsFire);
		anim.SetBool("Fire", onFire);

		shock = Physics2D.OverlapCircle(electricityCheck.position, electricityRadius, whatIsElectricity);
		anim.SetBool("Electricity", shock);

		// Set the vertical animation
		anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

		if (grounded)
		{
			doubleJump = false;
			tripleJump = false;
			fourthJump = false;
		}

		if (grounded)
		{
			audio.volume = 0.2f;
		}

		else 
		{
			audio.volume = 0;	
		}
	}

	public void Move(float move)
	{

		//only control the player if grounded or airControl is turned on
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

	public void Jump(bool jump)
	{	
		// If the player should jump...
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