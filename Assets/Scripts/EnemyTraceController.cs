
using UnityEngine;

public class EnemyTraceController : MonoBehaviour
{
    public float moveSpeed = .5f;
    public float raycastDistance = .2f;
    public float tranceDistance = .2f;
    public float stopDistance = 10f;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.position - transform.position;
        float distanceToPlayer = direction.magnitude;

        if (distanceToPlayer > stopDistance)
        {
            // 추적 멈춤, 이 부분에서 추가 동작을 설정할 수 있음
            Debug.Log("Enemy stopped chasing (too far).");
            return; // 추적을 멈추고 아무 동작도 하지 않음
        }

        if (direction.magnitude < tranceDistance)
            return;

        Vector2 directionNormalized = direction.normalized;

        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, directionNormalized, raycastDistance);
        Debug.DrawRay(transform.position, directionNormalized * raycastDistance, Color.red);

        foreach (RaycastHit2D rHit in hits)
        {
            if (rHit.collider != null && rHit.collider.CompareTag("Obstacle"))
            {
                Vector3 alternativeDirection = Quaternion.Euler(0f, 0f, -90f) * direction;
                transform.Translate(alternativeDirection * moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
        }


    }
}