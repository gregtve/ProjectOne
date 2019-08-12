using UnityEngine;

public abstract class SceneObjectBase : MonoBehaviour
{
	private bool _isVisible;
	public Transform Transform { get; private set; }

	public string Name
	{
		get => gameObject.name;
		set => gameObject.name = value;
	}

	public bool IsVisible
	{
		get => _isVisible;
		set
		{
			_isVisible = value;
			var tempRenderer = GetComponent<Renderer>();
			if (tempRenderer)
				tempRenderer.enabled = _isVisible;
			if (transform.childCount <= 0)
				return;
			foreach (Transform d in transform)
			{
				tempRenderer = d.gameObject.GetComponent<Renderer>();
				if (tempRenderer)
					tempRenderer.enabled = _isVisible;
			}
		}
	}

	public void SetActive(bool value)
	{
		IsVisible = value;
		var tempCollider = GetComponent<Collider>();
		if (tempCollider)
		{
			tempCollider.enabled = value;
		}
	}

	protected virtual void Awake()
	{
		Transform = transform;
	}
}
