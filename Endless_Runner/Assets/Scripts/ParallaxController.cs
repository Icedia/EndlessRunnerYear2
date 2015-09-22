using UnityEngine;
using System.Collections;

public class ParallaxController : MonoBehaviour {

	public ParallaxLayers[] layers;

	public void Scroll(Vector2 direction)
	{
		for (int i = 0; i < layers.Length; i++)
		{
			layers[i].Scroll(direction);
		}
	}
}
