using UnityEngine;
using System.Collections;

public class SpidBehavior : MonoBehaviour {
	public Transform[] Points;
	public float speed;
	public int curWayPoint;
	private int AnimNum;
	public bool patrol=true;
	public Vector3 Target,MoveDirection,Velocity;
	static Animator Anim;

	void Start(){
		Anim = GetComponent<Animator>();


	}
	// Update is called once per frame
	void Update () {
		Anim.SetBool("Idle",false);
		Anim.SetBool("IsWalking",true);
		if (curWayPoint < Points.Length) {
			Target = Points [curWayPoint].position;
			MoveDirection = Target - transform.position;
			Velocity = rigidbody.velocity;
			
			if (MoveDirection.magnitude < 1) {
				curWayPoint++;
			} else {
				Velocity = MoveDirection.normalized * speed;
			}
		} else {
			if(patrol){
				curWayPoint=0;
			}
			else{
				Velocity=Vector3.zero;
				Anim.SetBool("Idle",true);
				Anim.SetBool("IsWalking",false);
			}
		}
		rigidbody.velocity = Velocity;
		transform.LookAt (Target);
	}
		
		/*AnimNum=Random.Range (1, 4);
		if (AnimNum == 1) {
			Walk ();
		} else if (AnimNum == 2) {
			Walk2 ();
		} else {
			Walk3();
		}*/


}
