using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour { 
    Animator movementAnimator;
    public int moveSpeed;
    void Start()
    {
        movementAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * +moveSpeed * Time.deltaTime;
            movementAnimator.SetInteger("Animation State", 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * +moveSpeed * Time.deltaTime;
            movementAnimator.SetInteger("Animation State", 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * +moveSpeed * Time.deltaTime;
            movementAnimator.SetInteger("Animation State", 3);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * +moveSpeed * Time.deltaTime;
            movementAnimator.SetInteger("Animation State", 2);
        }
    }
}
