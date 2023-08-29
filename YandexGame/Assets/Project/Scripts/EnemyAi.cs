using System;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Collider2D floorCollider2D;
    private Vector3 _target;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    private void OnEnable()
    {
        if (gameManager.onePlayer)
        {
            _target = RandomPointInBounds(floorCollider2D.bounds);
            _agent.SetDestination(_target);
        }
    }

    private void Update()
    {
        if (!gameManager.onePlayer) return;
        if (!(Vector2.Distance(transform.position, _target) < 0.55f)) return;
        _target = RandomPointInBounds(floorCollider2D.bounds);
        _agent.SetDestination(_target);
    }

    private Vector2 RandomPointInBounds(Bounds bounds)
    {
        return new Vector2(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y)
        );
    }
}