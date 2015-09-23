using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public string levelToLoad;
	
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.transform.tag == "Box") 
		{
			Application.LoadLevel (levelToLoad);
		}
	}
}
