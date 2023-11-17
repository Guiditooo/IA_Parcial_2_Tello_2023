using System;
using ParcialTello.Managers;
using UnityEngine;

namespace ParcialTello.Agents
{
    public class Agent : MonoBehaviour
    {
        private int foodEaten = 0;
        private Vector2Int gridPos;
        public Vector2Int GridPos => gridPos;

        private void Awake()
        {

        }
        public void Eat()
        {

        }
        private void Move(float left, float up, float right, float down, float stop)
        {
            if (IsMaxValue(left,up,right,down,stop))
            {
                MoveDirection(Direction.Left);
            }
            if (IsMaxValue(up, left, right, down, stop))
            {
                MoveDirection(Direction.Up);
            }
            if (IsMaxValue(right, left, up, down, stop))
            {
                MoveDirection(Direction.Right);
            }
            if (IsMaxValue(down, left, up, right, stop))
            {
                MoveDirection(Direction.Down);
            }
            if (IsMaxValue(stop, left, up, right, down))
            {
                MoveDirection(Direction.Stop);
            }
        }

        private bool IsMaxValue(float value, params float[] param)
        {
            for (int i = 0; i < param.Length; i++)
                if (value < param[i])
                    return false;

            return true;
        }

        public void MoveDirection(Direction dir)
        {
            Vector2Int nextPos = gridPos;
            switch (dir)
            {
                case Direction.Left:
                    nextPos.x--;
                    break;
                case Direction.Up:
                    nextPos.y++;
                    break;
                case Direction.Right:
                    nextPos.x++;
                    break;
                case Direction.Down:
                    nextPos.y--;
                    break;
                case Direction.Stop:
                default:
                    return;
            }
            
            if (GridManager.IsValidPosition(nextPos))
            {
                gridPos = nextPos;
            }
        }

    }
}
