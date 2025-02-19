using UnityEngine;
using System.Collections;
public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float timeBetweenMoves = 5f;
    private float moveDuration = 1f;
    private float timer = 0f;
    private Vector2 randomDirection;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // When the timer reaches the interval, change direction
        if (timer >= timeBetweenMoves)
        {
            timer = 0f;
            randomDirection = GetRandomDirection();
            StartCoroutine(WalkInRandomDirection());
        }
    }

    private Vector2 GetRandomDirection()
    {
        // Choose a random direction (angle between 0 and 360 degrees)
        float angle = Random.Range(0f, 360f);
        return new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }

    private IEnumerator WalkInRandomDirection()
    {
        // Move in the random direction for 1 second
        float elapsedTime = 0f;
        while (elapsedTime < moveDuration)
        {
            transform.Translate(randomDirection * moveSpeed * Time.deltaTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
