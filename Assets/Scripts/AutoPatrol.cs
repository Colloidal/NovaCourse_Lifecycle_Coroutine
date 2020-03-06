using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPatrol : MonoBehaviour
{
    public Vector3[] points;
    public float movingSpeed;

    private void Start()
    {
        StartCoroutine(MoveToPoint());
    }

    IEnumerator MoveToPoint()
    {
        while (true)
        {
            foreach (var eachPoint in points)
                yield return StartCoroutine(Moving(eachPoint));
        }
    }
    IEnumerator Moving(Vector3 destination)
    {
        while (transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, movingSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
