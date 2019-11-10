using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoDialogue : MonoBehaviour
{
    public float waitingTime;
    private bool isSpeaking;
    public Text text;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        text.text = ("啊呀开始了吗?如果您要我等待" + waitingTime + "s后说话，请按下O键噢!!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && !isSpeaking)
        {
            StartCoroutine(Speaking());
        }
    }

    IEnumerator WaitForTime()
    {
        int step = 0;
        while (step <= waitingTime)
        {
            yield return new WaitForSeconds(1);
            timeText.text = "倒计时：" + (waitingTime - step++) + "s";
        }
        step = 0;
    }

    IEnumerator Speaking()
    {
        isSpeaking = !isSpeaking;
        yield return WaitForTime();
        text.text = ("现在已经过了" + waitingTime + "s惹，我可以说话了。");
        yield return WaitForTime();
        text.text = ("又过了" + waitingTime + "s，我累了，我不说话惹。");
        yield return WaitForTime();
        text.text = ("当然如果您还想听我说话的话，您可以再按一次O键噢(小声");
        isSpeaking = !isSpeaking;
    }
}
