using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Item Effects/Change Attack")]
public class ChangeAttack : ItemEffect
{
    [SerializeField] float changeAttack = 0;

    public override void UseItem()
    {
        throw new System.NotImplementedException();
    }
}