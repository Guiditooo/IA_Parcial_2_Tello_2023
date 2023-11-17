using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private Button btnStart;
        [SerializeField] private CanvasGroup panelConfig;
        [SerializeField] private CanvasGroup panelSimultion;
        public static Action OnStartButtonClicked;

        private void Awake()
        {
            btnStart.onClick.AddListener(StartSimulation);
            ShowPanel(panelConfig);
            HidePanel(panelSimultion);
        }

        private void StartSimulation()
        {
            HidePanel(panelConfig);
            ShowPanel(panelSimultion);
            OnStartButtonClicked?.Invoke();
        }

        private void ShowPanel(CanvasGroup panel)
        {
            panel.alpha = 1;
            panel.blocksRaycasts = true;
            panel.interactable = true;
        }
        private void HidePanel(CanvasGroup panel)
        {
            panel.alpha = 0;
            panel.blocksRaycasts = false;
            panel.interactable = false;
        }
    }
}