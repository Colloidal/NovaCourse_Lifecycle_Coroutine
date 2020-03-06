using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradualChange : MonoBehaviour
{
    private Renderer m_Renderer;
    public bool isFading = false;

    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && !isFading)
        {
            StartCoroutine(Fade());
        }
        if (Input.GetKeyDown(KeyCode.P) && isFading)
        {
            StartCoroutine(Show());
        }
    }

    IEnumerator Fade()
    {
        isFading = !isFading;
        float AlphaValue = m_Renderer.material.color.a;
        while (AlphaValue > 0f)
        {
            AlphaValue -= 0.01f;
            m_Renderer.material.color = new Color(m_Renderer.material.color.r, m_Renderer.material.color.g, m_Renderer.material.color.b, AlphaValue);
            yield return null;
        }
    }

    IEnumerator Show()
    {
        isFading = !isFading;
        float AlphaValue = m_Renderer.material.color.a;
        while (AlphaValue < 1f)
        {
            AlphaValue += 0.01f;
            m_Renderer.material.color = new Color(m_Renderer.material.color.r, m_Renderer.material.color.g, m_Renderer.material.color.b, AlphaValue);
            yield return null;
        }
    }
}
