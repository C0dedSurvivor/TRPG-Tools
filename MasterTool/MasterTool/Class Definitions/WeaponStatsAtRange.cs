﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum DamageType
{
    Physical,
    Magical
}

/// <summary>
/// Some weapons have different stats or effects based on how far away the pawn being hit is
/// </summary>
public class WeaponStatsAtRange
{
    public DamageType damageType;
    //At what distance the weapon gets these effects
    public int atDistance;
    //Can it deal damage
    public bool damages;
    //Does it heal
    public bool heals;
    //Is the weapon ranged. If it is, attack spaces don't depend on whether the previous space is passable
    public bool ranged;
    //Damage multiplier
    public float damageMult;
    public WeaponStatsAtRange(int distance, bool ranged, DamageType type, bool damages, bool heals, float multiplier = 1)
    {
        atDistance = distance;
        this.ranged = ranged;
        damageType = type;
        this.damages = damages;
        this.heals = heals;
        damageMult = multiplier;
    }
}