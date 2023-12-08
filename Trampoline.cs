using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 10f;
    void OnTriggerEnter(Collider other)
    {
        //важное уточнение
        //в отличии от других скриптов, здесь нет звука
        //потому что звук проигрывается в самом скрипте Jump.cs
        //вот отрывок кода

        //if (Input.GetButtonDown("Jump") && (!groundCheck || groundCheck.isGrounded))
        //{
            //if (jumpStrength>5) {
                //boinkSound.Play();
            //}
        
        //это сделано для того, чтобы звук воспроизводился ТОЛЬКО во время прыжка
        //вот такие пироги :D
        other.GetComponent<Jump>().jumpStrength = jumpFactor;
        print("jump");
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 5;
        print("no jump :(");
    }

}
