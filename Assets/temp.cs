using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class temp : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField _inputField;
    
    private int randNumber = 0;
    private void Start()
    {
         randNumber = Random.Range(0, 101);
        Debug.Log(randNumber);
    }

    public void onClickNumber()
    {
        if (_inputField.text == randNumber.ToString())
        {
            text.text = "Вы угадали число !";
        }

       
        else if (Convert.ToInt32(_inputField.text) > randNumber)
        {
            text.text = "число меньше";
        }
        else if (Convert.ToInt32(_inputField.text) < randNumber)
        {
            text.text = "число больше";
        }
        else if (Convert.ToInt32(_inputField.text) > 101)
        {
            text.text = "такого числа не существует";
        }
    }
    
}
