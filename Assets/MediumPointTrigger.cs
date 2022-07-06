using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumPointTrigger : MonoBehaviour
{
    public Score score;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            score.Scorer = score.Scorer + 100;
        }
    }
}
