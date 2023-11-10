using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ParcialTello.Grid
{
    public class GridManager : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private TMP_InputField heightInput;
        [SerializeField] private TMP_InputField widthInput;
        [SerializeField] private Button initializerButton;
        [Header("Prefab")] 
        [SerializeField] private GameObject tilePrefab;

        private Vector2 GridSize = Vector2.zero;

        private const int MIN_VALUES = 100;

        private void Awake()
        {
            GridSize = Vector2.zero;
            initializerButton.onClick.AddListener(InitializeGrid);
        }

        private void OnDestroy()
        {
            initializerButton.onClick.RemoveListener(InitializeGrid);
        }

        private void InitializeGrid()
        {
            float auxFloat = 0;
            float.TryParse(widthInput.text, out auxFloat);
            GridSize.x = auxFloat;
            float.TryParse(heightInput.text, out auxFloat);
            GridSize.y = auxFloat;

            for (int i = 0; i < GridSize.y; i++)
            {
                for (int j = 0; j < GridSize.x; j++)
                {
                    
                }
            }
        }



    }
}
