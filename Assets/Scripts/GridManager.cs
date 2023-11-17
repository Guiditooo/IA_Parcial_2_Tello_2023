using System.Collections.Generic;
using ParcialTello.Grid;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ParcialTello.Managers
{
    public class GridManager : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private TMP_InputField heightInput;
        [SerializeField] private TMP_InputField widthInput;
        [SerializeField] private Button initializerButton;
        [Header("Prefab")] 
        [SerializeField] private GameObject tilePrefab;

        private static Vector2Int gridSize = Vector2Int.zero;

        private List<Tile> tileList = new List<Tile>();

        private const int MIN_VALUES = 100;

        private void Awake()
        {
            gridSize = Vector2Int.zero;
            initializerButton.onClick.AddListener(InitializeGrid);
        }

        private void OnDestroy()
        {
            initializerButton.onClick.RemoveListener(InitializeGrid);
        }

        private void InitializeGrid()
        {
            int auxInt = 0;
            int.TryParse(widthInput.text, out auxInt);
            gridSize.x = auxInt;
            int.TryParse(heightInput.text, out auxInt);
            gridSize.y = auxInt;

            for (int i = 0; i < gridSize.y; i++)
            {
                for (int j = 0; j < gridSize.x; j++)
                {
                    tileList.Add(new Tile());
                }
            }

            for (int i = 0; i < gridSize.x*2 ; i++)
            {
                Vector2Int auxFoodPos;
                do
                {
                    auxFoodPos = new Vector2Int(Random.Range(0, gridSize.x - 1), Random.Range(1, gridSize.y));
                } while (tileList[(auxFoodPos.y * gridSize.y) + auxFoodPos.x].HasFood());
                tileList[(auxFoodPos.y * gridSize.y) + auxFoodPos.x].SetFood();
            }

        }
        
        public static bool IsValidPosition(Vector2Int checkPos)
        {
            return !(checkPos.y < 0 || checkPos.y > gridSize.y);
        }



    }
}
