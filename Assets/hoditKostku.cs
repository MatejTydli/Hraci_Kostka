using UnityEngine;

public class hoditKostku : MonoBehaviour
{
	public Rigidbody kostka;
	public Camera kamera;
	public float range = 50f;

	private Vector3 savedPos;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && kostka.velocity == Vector3.zero)
		{
			Debug.LogWarning("Yep");
			kostka.AddForce(new Vector3(Random.Range(-range, range), Random.Range(0, range / 3), Random.Range(-range, range)), ForceMode.Impulse);
		}

		if (kostka.position.y < -1)
		{
			kostka.position = new Vector3(0, 3, 0);
		}

		kamera.transform.position = new Vector3(kostka.position.x, kostka.position.y + 10, kostka.position.z);
		savedPos = kostka.position;
	}
}
