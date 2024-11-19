using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed;
    Vector3 playerPosition;


    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        if (transform.position == playerPosition)
        {
            DestroyWhenReached();
        }

    }

    void DestroyWhenReached()
    {
        Destroy(gameObject);
    }
}
