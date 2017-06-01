using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBounds : MonoBehaviour 
{
	public Transform ListenerTransform;
	public Collider BoundsCollider;

	private void Update()
	{
		if (null == BoundsCollider || null == ListenerTransform)
		{
			return;
		}

		transform.position = BoundsCollider.ClosestPoint(ListenerTransform.position);
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireSphere(transform.position, 0.5f);
	}
}
