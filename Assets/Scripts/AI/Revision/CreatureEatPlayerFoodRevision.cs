﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CreatureEatPlayerFoodRevision : ActionRevision
{
    public void Revise(Agent reviseur, Creature from, FoodType foodType) {
        if(reviseur.Creature.SpecieID == from.SpecieID) {
            base.Revise(reviseur);
        }

        DataSpecies data = reviseur.Memory.Species.GetByKey(from.SpecieID);
        if(data == null) return;

        data.addHerbivorFood(new HerbivorFood(foodType, Time.time));
    }
}
