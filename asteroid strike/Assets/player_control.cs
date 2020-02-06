using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
   	//variables
	public float moveSpeed ;
	public GameObject character;

	private Rigidbody2D characterBody;
	private float ScreenWidth;
    public static Vector2 position;
    private Vector3 m_Velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;
		
        characterBody = character.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				//move right
                
				RunCharacter (1.0f);
                
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
                
				RunCharacter (-1.0f);
               
                
			}
			++i;
		}
	}
	void FixedUpdate(){
		#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
		#endif
	}

	private void RunCharacter(float horizontalInput){
		//move player
        Vector3 targetVelocity = new Vector2(horizontalInput *moveSpeed* Time.fixedDeltaTime,0f);
        characterBody.velocity = Vector3.SmoothDamp(characterBody.velocity, targetVelocity, ref m_Velocity, .5f);
		//characterBody.MovePosition(new Vector2(horizontalInput * moveSpeed, 0));

	}
}