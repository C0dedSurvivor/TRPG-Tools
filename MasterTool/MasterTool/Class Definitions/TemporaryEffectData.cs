﻿/// <summary>
/// Stores all of the unique, mutable data necessary to correctly active an effect during a battle
/// </summary>
public class TemporaryEffectData
{
    public int maxTimesThisBattle;
    public int turnCooldown;
    public int maxActiveTurns;

    public TemporaryEffectData(int maxTimesThisBattle = -1, int turnCooldown = -1, int maxActiveTurns = -1)
    {
        this.maxTimesThisBattle = maxTimesThisBattle;
        this.turnCooldown = turnCooldown;
        this.maxActiveTurns = maxActiveTurns;
    }
}