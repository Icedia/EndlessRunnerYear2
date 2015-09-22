using UnityEngine;
using System.Collections;

public class ParallaxLayers : MonoBehaviour {
	
	public float scrollSpeed;

	
	// Update is called once per frame
	public void Scroll (Vector2 scrollDirection) {
		transform.Translate(scrollDirection * scrollSpeed * Time.deltaTime);
	}
}
