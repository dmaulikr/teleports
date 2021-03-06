﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlotUI : UnlockableSlotUI {

    [SerializeField]
    private int skillSlotId;

    private SkillTreeSlot skillSlot;

    protected override UnlockableSlot GetSlot()
    {
        skillSlot = MainData.CurrentPlayerData.GetSkillTreeSlot(skillSlotId);
        return skillSlot;
    }

    protected override void OnFull()
    {
        base.OnFull();
        text.text = MainData.CurrentPlayerData.GetSkillTreeSlotLevel(skillSlotId).ToString();
    }

    public void SetSlotID(int id)
    {
        skillSlotId = id;
    }
}
