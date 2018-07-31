using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    enum AnimationState
    {
        idleDown = 0,
        idleRight = 1,
        idleUp= 2,
        idleLeft= 3,
        movDown = 4,
        movRight = 5,
        movDown = 6,
        movRight = 7,
    }
    Animator movementAnimator;
    int movementKey;
    void Start()
    {
        movementAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown())
        {

        }
    }

    int ChangeAnimatorState(int animatorState)
    {
        switch (animatorState)
        {
            case 0:
                movementAnimator.SetInteger("Estado", animatorState);
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
        }
    }
}
