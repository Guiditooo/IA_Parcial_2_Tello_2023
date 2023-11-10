using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ParcialTello.UI
{
    public class UIController : MonoBehaviour
    {
        [Header("Sliders")]
        [SerializeField] private Slider sliderHeight;
        [SerializeField] private Slider sliderWidth;
        [SerializeField] private TMP_Text textHeight;
        [SerializeField] private TMP_Text textWidth;
        [Header("Panel Shutdown")] 
        [SerializeField] private Button buttonStart;
        [SerializeField] private CanvasGroup panelConfiguration;
        private void Awake()
        {
            sliderHeight.onValueChanged.AddListener(OnHeightChanged);
            sliderWidth.onValueChanged.AddListener(OnWidthChanged);
            buttonStart.onClick.AddListener(StartGame);
        }

        private void Start()
        {
            SetHeightText(sliderHeight.value.ToString("F0"));
            SetWidthText(sliderWidth.value.ToString("F0"));
        }

        private void OnDestroy()
        {
            sliderHeight.onValueChanged.RemoveAllListeners();
            sliderWidth.onValueChanged.RemoveAllListeners();
            buttonStart.onClick.RemoveAllListeners();
        }

        private void OnHeightChanged(float arg0)
        {
            SetHeightText(arg0.ToString("F0"));
        }
        private void OnWidthChanged(float arg0)
        {
            SetWidthText(arg0.ToString("F0"));
        }

        private void SetWidthText(string value)
        {
            textWidth.text = "Width: " + value;
        }
        private void SetHeightText(string value)
        {
            textHeight.text = "Height: " + value;
        }
        private void StartGame()
        {
            HidePanel(panelConfiguration);
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
