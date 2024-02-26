using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

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
        int count;
        count = MovementScript.JumpCount;
        JumpText.text = "Jumps left : " + (count - 1);
    }
}
