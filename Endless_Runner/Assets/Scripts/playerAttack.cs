using UnityEngine;
using System.Collections;
/*/Author Rishaad Hausil/*/

public class playerAttack : MonoBehaviour
{
    private bool _attackingR = false;
    private bool _attackingL = false;
    private bool _attackingU = false;

    private float _attackTimer = 0;
    private float _attackCd = 0.2f;

    private Animator anim;

    public Collider2D attackTriggerR;
    public Collider2D attackTriggerL;
    public Collider2D attackTriggerU;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTriggerR.enabled = false;
        attackTriggerL.enabled = false;
        attackTriggerU.enabled = false;
    }
    void Update()
    {
        Attacking();
    }

    void Attacking()
    {
        if (Input.GetKeyDown(KeyCode.D) && !_attackingR)
        {
            _attackingR = true;
            _attackTimer = _attackCd;
            attackTriggerR.enabled = true;
            
        }

        if (Input.GetKeyDown(KeyCode.A) && !_attackingL)
        {
            _attackingL = true;
            _attackTimer = _attackCd;
            attackTriggerL.enabled = true;
         }

        if (Input.GetKeyDown(KeyCode.W) && !_attackingU)
        {
            _attackingU = true;
            _attackTimer = _attackCd;
            attackTriggerU.enabled = true;
        }

        if (_attackingR || _attackingL || _attackingU)
        {
            if (_attackTimer > 0)
            {
                _attackTimer -= Time.deltaTime;
            }
            else
            {
                _attackingR = false;
                _attackingL = false;
                _attackingU = false;
                attackTriggerR.enabled = false;
                attackTriggerL.enabled = false;
                attackTriggerU.enabled = false;
            }
        }

        anim.SetBool("AttackR", _attackingR);
        anim.SetBool("AttackL", _attackingL);
        anim.SetBool("AttackU", _attackingU);
    }
}



