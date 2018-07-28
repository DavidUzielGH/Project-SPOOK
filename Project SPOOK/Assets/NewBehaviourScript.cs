using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
    bool doesntmatter = false;
    public SpriteRenderer spritePlayer;
	void Start () {
        spritePlayer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (doesntmatter == false)
        {
            spritePlayer.transform.SetPositionAndRotation(new Vector2(3, 3), spritePlayer.transform.rotation);
            doesntmatter = true;
        }
        else if (doesntmatter == true)
        {
            spritePlayer.transform.SetPositionAndRotation(new Vector2(2, 2), spritePlayer.transform.rotation);
            doesntmatter = false;
        }
	}
}
