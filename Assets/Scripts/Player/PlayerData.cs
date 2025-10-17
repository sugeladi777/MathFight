using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Game/PlayerData")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public float moveSpeed;
    public int maxHealth;
    //public List<SkillData> skills;
}