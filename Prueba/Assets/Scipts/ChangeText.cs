using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] Text talkieText;

    public void ChangeTalkieText(string newText)
    {
        talkieText.text = newText;
    }
}
