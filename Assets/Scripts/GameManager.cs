using System;
using UnityEngine;

namespace ParcialTello.Managers
{
    // La simulacion posee 2 conceptos importantes: Turno y Ciclo.
    // El turno sucede cada vez que todos los agentes se mueven.
    // El ciclo sucede cada vez que pasan X cantidad de turnos.
    // Cada turno tiene 2 tiempos:
    // 1.El turno empieza y todos los agentes se mueven UNA casilla
    // 2.El turno termina y cada casillero se fija cuantos agentes tiene dentro.
    //  En caso de haber mas de 1 agente, debe indicar 

    public class GameManager
    {
        public static Action OnTurnEnded;
    }
}
