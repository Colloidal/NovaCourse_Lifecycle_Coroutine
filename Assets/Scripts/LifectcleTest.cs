using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifectcleTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake!!!");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!!!");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate!!!");
    }

    void Update()
    {
        Debug.Log("Update!!!");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate!!!");
    }


}
