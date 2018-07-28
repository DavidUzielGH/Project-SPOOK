using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
    bool doesntmatter = false;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (doesntmatter == false)
        {
            transform.SetPositionAndRotation(new Vector2(3, 3), transform.rotation);
            doesntmatter = true;
        }
        else if (doesntmatter == true)
        {
            transform.SetPositionAndRotation(new Vector2(2, 2), transform.rotation);
            doesntmatter = false;
        }
	}
}
