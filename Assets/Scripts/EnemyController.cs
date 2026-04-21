using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Target")]
    public Transform player;   // Drag player here in Inspector

    [Header("Movement")]
    public float moveSpeed = 3f;
    public float chaseRange = 10f;

    [Header("Attack")]
    public float attackRange = 2f;
    public int attackDamage = 10;       // Editable in Inspector
    public float attackCooldown = 1.5f; // Time between attacks

    private float nextAttackTime;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        // Chase Player
        if (distance <= chaseRange && distance > attackRange)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                moveSpeed * Time.deltaTime
            );
        }

        // Face Player
        transform.LookAt(player);

        // Attack Player
        if (distance <= attackRange && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown;
        }
    }

    void Attack()
    {
        Debug.Log("Enemy attacks for " + attackDamage + " damage!");
    }
}