using UnityEngine;

public class new_script : MonoBehaviour
{

    public Transform playerPosition;

    Vector2 directionToPlayer;

    int EnemySpeed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     playerPosition = null;   
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition != null)
        {
            directionToPlayer = (playerPosition.position - transform.position).normalized;
            Debug.Log(directionToPlayer);
        }

if (playerPosition.position - transform.position != Vector3.zero) MoveToPlayer(EnemySpeed);

    }

    public void MoveToPlayer(float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed * Time.deltaTime);
    }

}
