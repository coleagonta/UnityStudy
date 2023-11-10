using UnityEngine;
using UnityEngine.UI;
public class temp : MonoBehaviour
{
    private int b = 0;
    public Text text;
    
    public void onClickIncorrect()
    {
        text.text = "Количество неправильных ответов: " + (++b).ToString();
        Debug.Log(b);
    }
}
