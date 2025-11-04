using UnityEngine;


// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public float speed = 1f;
    private bool isChasing = false;
    private Vector3 targetPosition;

    public void StartChasing(Vector3 playerPosition)
    {
        isChasing = true;
        targetPosition = playerPosition;
    }

    public void StopChasing()
    {
        isChasing = false;
    }

    void Update()
    {
        if (isChasing)
        {
            // get direction vector --> normalize it to make the length 1 (so that the speed is constant)
            Vector3 direction = (targetPosition - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

}
