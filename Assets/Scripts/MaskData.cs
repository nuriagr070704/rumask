using UnityEngine;

[CreateAssetMenu(fileName = "NewMask", menuName = "RUMASK/Mask")]
public class MaskData : ScriptableObject
{
    public string maskName;
    public int extraDamage;
    public int extraLife;
    public Sprite maskSprite;
}
