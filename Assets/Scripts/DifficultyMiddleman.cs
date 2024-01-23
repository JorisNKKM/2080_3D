using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMiddleman : MonoBehaviour
{
    public int level;
    public BallMovement main;
    public void Easy()
    {
        level = 0;
    }
    public void Medium()
    {
        level = 1;
    }
    public void Hard()
    {
        level = 2;
    }

    public void Reecever()
    {
        Difficulty();
    }
    public void Difficulty()
    {
        if (level == 0) 
        {
            main.EasyDifficulty();
        }
        if (level == 1)
        {
            main.MediumDifficulty();
        }
        if(level == 2)
        {
            main.HardDifficulty();
        }
    }

}
