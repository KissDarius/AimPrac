using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	[SerializeField]
	private RawImage _img;

	[SerializeField]
	private float _x;

	[SerializeField]
	private float _y;

	private void Update()
	{
		_img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
	}
}
