﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSlotUISpawner : PrefabSpawner
{

    [SerializeField]
    private int skillSlotID;

    public override void AfterSpawn()
    {
        SkillSlotUI slot = spawnedInstance.GetComponent<SkillSlotUI>();

        slot.SetSlotID(skillSlotID);
        slot.LoadData();
    }
}
