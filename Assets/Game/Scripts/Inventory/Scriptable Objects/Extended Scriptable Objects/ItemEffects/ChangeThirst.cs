using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Item Effects/Change Thirst")]
public class ChangeThirst : ItemEffect
{
    [SerializeField] float changeThirst = 0;

    public override void UseItem()
    {
        throw new System.NotImplementedException();
    }
}