using UnityEngine;

public class EnemyMask : MonoBehaviour
{
    public int extraDamage = 1;

    public void ApplyMask(enemy_move enemy)
    {
        enemy.AddExtraDamage(extraDamage);
    }
}
