using UnityEngine;

public class Velocidade : MonoBehaviour
{
	private const float C = 5995.8416f/1000f;
	
//	public Vector3 
	public Vector3 ReferencialSpeed = Vector3.right;
	public Vector3 Speed = Vector3.right;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	private void Start ()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void FixedUpdate ()
	{
		var speed = Speed * C;
		var newPos = transform.position +=  speed * Time.fixedDeltaTime;
		_rigidbody2D.MovePosition(newPos);
		
		
	}
}