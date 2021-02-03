﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CreatureEvadePlayerRevision : ActionRevision
{
    public void Revise(Agent reviseur, Creature from) {
        if(reviseur.Creature.SpecieID == from.SpecieID) {
            base.Revise(reviseur);
        }
    }
}