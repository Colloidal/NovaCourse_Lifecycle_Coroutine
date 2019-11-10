using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private Coroutine para;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActiveByMethod(1,2));
        StartCoroutine("ActiveByName",1);
        para = StartCoroutine(ActiveByParameter(1,2));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            StopCoroutine(ActiveByMethod(0,0));
            StopCoroutine("ActiveByName");
            StopCoroutine(para);
        }
    }

    IEnumerator ActiveByMethod(int first, int second)
    {
        while (true)
        {
            Debug.Log("由函数启动的协程在运行，输入值分别为" + first + "&" + second);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ActiveByName(int first)
    {
        while (true)
        {
            Debug.Log("由名字字符串启动的协程在运行，输入值分别为" + first);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ActiveByParameter(int first, int second)
    {
        while (true)
        {
            Debug.Log("由变量启动的协程在运行，输入值分别为" + first + "&" + second);
            yield return new WaitForSeconds(1);
        }
    }
}
