using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    [Header("Basic Enemy Data")]
    public float health;
    public float moveSpeed;

    [Header("Attack Data")]
    public float longRangeTimeBetween;
    public float[] attackDamages;
}
