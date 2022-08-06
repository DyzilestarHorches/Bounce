using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GameManagerData", menuName = "GameManagerData", order = 53)]
public class SO_GameManagerData : ScriptableObject
{
    public SO_MyState gameState;

    public Vector2 gameMove;
    public float gameSpeed;

    public int score;
    public int lastScore;
}
