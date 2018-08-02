using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour { 
    Animator movementAnimator;
    public int moveSpeed;
    int lastIdle;
    void Start()
    {
        movementAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * +moveSpeed * Time.deltaTime;
            setAnimatorParameters(0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * +moveSpeed * Time.deltaTime;
            setAnimatorParameters(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * +moveSpeed * Time.deltaTime;
            setAnimatorParameters(3);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * +moveSpeed * Time.deltaTime;
            setAnimatorParameters(2);
        }
        if (!Input.anyKey)
        {
            movementAnimator.SetBool("isIdle", true);
        }
    }
    private void setAnimatorParameters(int value)
    {
        movementAnimator.SetInteger("Animation State", value);
        movementAnimator.SetBool("isIdle", false);
    }
}
