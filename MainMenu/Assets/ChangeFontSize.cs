using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeFontSize : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMeshPro;

    private void Start()
    {
/*        _textMeshPro = GetComponentInChildren<TextMeshPro>()*/;
    }

    public void ChengeFontSize()
    {
        _textMeshPro.fontSize = 70;
    }
}
