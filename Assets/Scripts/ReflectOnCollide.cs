using UnityEngine;

public class ReflectOnCollide : MonoBehaviour
{

	private Velocidade _velocidade;
	public string Tag;

	private void Start()
	{
		_velocidade = GetComponent<Velocidade>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(Tag))
			_velocidade.Speed *= -1;
	}



}
