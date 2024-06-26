using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pablo made this :>

public class MakeEmMove : MonoBehaviour
{
    public Animator Chicken;

    void movement()
    {
        if (Input.GetKey(KeyCode.W)){
            Chicken.SetBool("goUp", true);
        }
        else
        {
            Chicken.SetBool("goUp", false);
        }
        if (Input.GetKey(KeyCode.S)){
            Chicken.SetBool("goDown", true);
        }
        else
        {
            Chicken.SetBool("goDown", false);
        }
        if (Input.GetKey(KeyCode.A)){
            Chicken.SetBool("turnLeft", true);
        }
        else
        {
            Chicken.SetBool("turnLeft", false);
        }
        if (Input.GetKey(KeyCode.D)){
            Chicken.SetBool("turnRight", true);
        }
        else
        {
            Chicken.SetBool("turnRight", false);
        }
    }

    void Start()
    {
        Chicken = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
}
