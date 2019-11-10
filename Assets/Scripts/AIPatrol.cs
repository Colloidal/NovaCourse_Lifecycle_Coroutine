using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public Vector3[] path;  
    public float moveSpeed;

    private void Start()
    {
        StartCoroutine(MoveOnPath());
    }

    IEnumerator MoveOnPath()
    {
        do
        {
            foreach (var point in path)
                yield return StartCoroutine(MoveToPosition(point));
        }
        while (true);
    }

    IEnumerator MoveToPosition(Vector3 target)
    {
        while (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
            yield return 0;
        }
    }
}