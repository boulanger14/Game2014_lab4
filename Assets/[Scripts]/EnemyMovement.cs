using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Enemy Movement")]

    public Bounds movementBounds;
    public Bounds startRange;
    private float startingPoint;
    private float randomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.RandomRange(movementBounds.min, movementBounds.max);
        startingPoint = Random.RandomRange(startRange.min, startRange.max);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, randomSpeed) + startingPoint, transform.position.y);
    }
}
