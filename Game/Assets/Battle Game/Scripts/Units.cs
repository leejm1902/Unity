using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    RUN,
    ATTACK,
    DIE
}

[RequireComponent(typeof(Animator))]

public abstract class Units : MonoBehaviour
{
    protected float health;
    protected float attack;
    protected float speed;

    protected Collider target;
    protected Animator animator;

    protected State state;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch(state)
        {
            case State.RUN: Run();
                break;
            case State.ATTACK: Attack();
                break;
            case State.DIE: Die();
                break;
        }
    }

    protected virtual void Run()
    {
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected virtual void Attack()
    {
        speed = 0.0f;
        animator.SetBool("Attack", true);
    }

    protected virtual void Die()
    {
        animator.Play("Die");
        Destroy(gameObject);
    }

    public void Hit(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            state = State.DIE;
        }
    }
}
