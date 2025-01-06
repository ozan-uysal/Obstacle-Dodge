using Unity.VisualScripting;
using UnityEngine;

public class FlierToPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 0.1f;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed);
    }
}
