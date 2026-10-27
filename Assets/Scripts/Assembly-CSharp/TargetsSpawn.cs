using UnityEngine;

public class TargetsSpawn : MonoBehaviour
{
	public static TargetsSpawn Instance;

	[SerializeField]
	private BoxCollider col;

	private void Awake()
	{
		Instance = this;
	}

	public Vector3 GetRandomPossition()
	{
		Vector3 vector = col.center + base.transform.position;
		float minInclusive = vector.x - col.size.x / 2f;
		float maxInclusive = vector.x + col.size.x / 2f;
		float minInclusive2 = vector.y - col.size.y / 2f;
		float maxInclusive2 = vector.y + col.size.y / 2f;
		float minInclusive3 = vector.z - col.size.z / 2f;
		float maxInclusive3 = vector.z + col.size.z / 2f;
		float x = Random.Range(minInclusive, maxInclusive);
		float y = Random.Range(minInclusive2, maxInclusive2);
		float z = Random.Range(minInclusive3, maxInclusive3);
		return new Vector3(x, y, z);
	}
}
