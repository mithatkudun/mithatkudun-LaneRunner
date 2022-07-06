using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public TMP_Text Scoretext;
    public int Scorer;
    void Update()
    {
        Scoretext.text = "Score = " + Scorer.ToString();
    }

}
