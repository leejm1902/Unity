using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

[RequireComponent(typeof(HPBar))]

public class MyUnit : Units
{
    protected HPBar hpBar;

    void Start()
    {
        health = 100;
        attack = 10;
        speed = 1.0f;

        maxHP = health;
        hpBar = GetComponent<HPBar>();

        animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("My Unit Animator");
    }

    public void Damage()
    {
        target.GetComponent<EnemyUnit>().Hit(attack);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EnemyUnit"))
        {
            target = other;
            state = State.ATTACK;
        }
    }

    public override void Hit(float damage)
    {
        health -= damage;

        hpBar.CurrentHP(health, maxHP);

        if (health <= 0)
        {
            state = State.DIE;
            target.GetComponent<EnemyUnit>().state = State.RUN;
        }
    }
}
