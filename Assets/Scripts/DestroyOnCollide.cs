using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{

	public string Tag;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.CompareTag(Tag))
			Destroy(gameObject);
	}



}
