using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI JumpText;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        JumpText.text = "Jumps left : " + MovementScript.JumpCount;
    }
}
