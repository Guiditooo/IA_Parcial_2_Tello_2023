using System.Collections.Generic;
using ParcialTello.Agents;
using Unity.Mathematics;
using UnityEngine;

namespace ParcialTello.Grid
{
    public class Tile : MonoBehaviour
    {
        private bool hasFood = false;
        private List<Agent> insideAgentList;
        public void SetFood() => hasFood = true;
        public bool HasFood() => hasFood;

        //Suscribir a OnTurnEnded para chequear si tiene mas de un agente adentro
    }
}