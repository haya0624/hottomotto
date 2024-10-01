using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField]
    Animator animator = null;
    [SerializeField]
    CapsuleCollider capsuleCollider = null;
    [SerializeField, Min(0)]
    int maxHp = 3;
    [SerializeField]
    float deadWaitTime = 3;

    // �A�j���[�^�[�̃p�����[�^�[��ID���擾�i�������̂��߁j
    readonly int SpeedHash = Animator.StringToHash("Speed");
    readonly int AttackHash = Animator.StringToHash("Attack");
    readonly int DeadHash = Animator.StringToHash("Dead");

    bool isDead = false;
    int hp = 0;
    Transform thisTransform;

    public int Hp
    {
        set
        {
            hp = Mathf.Clamp(value, 0, maxHp);
        }
        get
        {
            return hp;
        }
    }

    void Start()
    {
        thisTransform = transform;  // transform���L���b�V���i�������j

        InitEnemy();
    }

    void Update()
    {
        if (isDead)
        {
            return;
        }

        UpdateAnimator();
    }

    void InitEnemy()
    {
        Hp = maxHp;
    }

    // ��_���[�W����
    public void Damage(int value)
    {
        if (value <= 0)
        {
            return;
        }

        Hp -= value;

        if (Hp <= 0)
        {
            Dead();
        }
    }

    // ���S���̏���
    void Dead()
    {
        isDead = true;
        capsuleCollider.enabled = false;
        animator.SetBool(DeadHash, true);

        StartCoroutine(nameof(DeadTimer));
    }

    // ���S���Ă��琔�b�ԑ҂���
    IEnumerator DeadTimer()
    {
        yield return new WaitForSeconds(deadWaitTime);

        Destroy(gameObject);
    }

    // �A�j���[�^�[�̃A�b�v�f�[�g����
    void UpdateAnimator()
    {

    }

}