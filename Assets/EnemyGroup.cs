using System;
using System.Collections;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int columns = 10;
    public int rows = 4;
    public float movementIntervals = 0.5f;
    public float horizontalSpeed = 1f;
    public float fireRate = 0.5f;
    public float leftBound = -9;
    public float rightBound = 9;
    

    private void Start()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Instantiate(enemyPrefab, new Vector3(column, row, 0)+transform.position, Quaternion.identity, transform);
            }
        }
        StartCoroutine(nameof(Movement));
        // StartCoroutine(nameof(Shoot));
    }

    private IEnumerator Movement()
    {
        while (true)
        {
            transform.position += Vector3.right * horizontalSpeed;
            yield return new WaitForSeconds(movementIntervals);
            if (transform.position.x >= rightBound || transform.position.x <= leftBound)
            {
                horizontalSpeed *= -1;
                transform.position += Vector3.down * 0.5f;
                yield return new WaitForSeconds(movementIntervals);
            }
        }
    }
}
