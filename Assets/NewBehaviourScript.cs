using System;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
   public Text text;
     int a = 0;
       public void onClickCorrect()
         {
             text.text = "Количество правильных ответов: " + (++a).ToString();
             Debug.Log(a);
         }
}
