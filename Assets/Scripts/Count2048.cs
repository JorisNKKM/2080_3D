using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Count2048 : MonoBehaviour
{
    public int Balls = -1;
    public TMP_Text Text;
    public void Start()
    {
        Balls++;
        
    }

    void Update()
    {

        Text.text = Balls.ToString();
    }
}
