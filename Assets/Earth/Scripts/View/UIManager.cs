using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    private static string DEFAULT_VALUE = "";

    [SerializeField] private Text text;

    public void Update(string pText)
    {
        if (pText != null)
        {
            text.text = pText;
        } else
        {
            text.text = DEFAULT_VALUE;
        }
    }
}
