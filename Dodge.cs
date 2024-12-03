using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    bool m_HasPlayerDodged;

    public Transform player;
    public Score1 score;



    void Start()
    {
        m_HasPlayerDodged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_HasPlayerDodged == true)
        {
            score.EarnScore(3);
            m_HasPlayerDodged = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_HasPlayerDodged = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {

            m_HasPlayerDodged = true;
        }
    }
}
