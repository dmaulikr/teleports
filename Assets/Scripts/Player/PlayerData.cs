﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataa : ScriptableObject {

    static int probeLength_ = 5;

    public string name_;
    int xp_, startXp_;
    int level_;
    int rankPoints_;

    public int xp
    {
        set {
            xp_ = value;
        }
        get { return xp_; }
    }
    public int startXp
    {
        get
        {
            return startXp_;
        }

        set
        {
            startXp_ = value;
        }
    }
    public int requiredXp
    {
        get
        {
            return XpLevels.RequiredXp(xp_);
        }
    }
    public int currentXp
    {
        get
        {
            return XpLevels.CurrentXp(xp_);
        }
    }
    public int level
    {
        get {
            updateLevel();
            return level_;
        }
    }
    public int RankPoints
    {
        get { return rankPoints_; }
    }

    void updateLevel()
    {
        level_ = XpLevels.Level(xp_);
    }

    public void updateRankPoints(int score)
    {
        rankPoints_ += (score - rankPoints_) / probeLength_;
    }
}
