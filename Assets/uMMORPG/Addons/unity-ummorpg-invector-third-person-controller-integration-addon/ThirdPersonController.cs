using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    void LateUpdate_v() {
        foreach (Animator anim in GetComponentsInChildren<Animator>())
        {
            /* FUNCIONAAAAAAA
             * Recibe del servidor si el personaje se está moviendo
             */
            if (anim.GetBool("MOVING") == true)
            {
                anim.SetFloat("InputMagnitude", 1, 0.25f, Time.deltaTime); // 1 si el personaje se mueve
            }
            else {
                anim.SetFloat("InputMagnitude", 0, 0.25f, Time.deltaTime); // 0 si el personaje no se mueve
            }

            // ATTACK ANIMATION
            if (anim.GetBool("Normal Attack (Warrior)") == true)
            {
                anim.SetInteger("AttackID", 1);
                anim.SetBool("WeakAttack", true);
            }
            else
            {
                anim.SetBool("WeakAttack", false);
            }

            // DEAD ANIMATION
            if (anim.GetBool("DEAD") == true)
            {
                anim.SetBool("isDead", true);
            }
            else
            {
                anim.SetBool("isDead", false);
            }

            // SET ANIMATION
            anim.SetFloat("MoveSet_ID", 1f);
        }
    }
}

namespace xyz.germanfica.Invector.ThirdPersonController
{
    public class ThirdPersonController {}
}
