using UnityEngine;
using System.Collections;

public class sceneHandling : MonoBehaviour {

    public void switchLevel(string Level)
    {   
        Application.LoadLevel(Level);
    }
}
