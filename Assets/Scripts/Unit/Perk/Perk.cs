﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perk : MonoBehaviour {

    bool isApplied_ = false;
    public bool isApplied
    {
        get { return isApplied_; }
    }

    public string name_;

	public virtual void Apply(Unit target)
    {
        if (!isApplied_)
        {
            isApplied_ = true;
        }
        else return;
    }

    public virtual void unapply(Unit target)
    {
    }

    public virtual void onCast(Unit caster, Skill skill, Skill.TargetInfo target)
    {

    }
}
