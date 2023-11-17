using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class StartConfigurationScreen : MonoBehaviour
{
    [Header("Population Manager")] 
    [SerializeField] private PopulationManager popManager;

    [Header("UI")]
    public Text populationCountTxt;
    public Slider populationCountSlider;
    public Text minesCountTxt;
    public Slider minesCountSlider;
    public Text generationDurationTxt;
    public Slider generationDurationSlider;
    public Text eliteCountTxt;
    public Slider eliteCountSlider;
    public Text mutationChanceTxt;
    public Slider mutationChanceSlider;
    public Text mutationRateTxt;
    public Slider mutationRateSlider;
    public Text hiddenLayersCountTxt;
    public Slider hiddenLayersCountSlider;
    public Text neuronsPerHLCountTxt;
    public Slider neuronsPerHLSlider;
    public Text biasTxt;
    public Slider biasSlider;
    public Text sigmoidSlopeTxt;
    public Slider sigmoidSlopeSlider;
    public GameObject simulationScreen;
    
    string populationText;
    string minesText;
    string generationDurationText;
    string elitesText;
    string mutationChanceText;
    string mutationRateText;
    string hiddenLayersCountText;
    string biasText;
    string sigmoidSlopeText;
    string neuronsPerHLCountText;

    void Start()
    {   
        populationCountSlider.onValueChanged.AddListener(OnPopulationCountChange);
        minesCountSlider.onValueChanged.AddListener(OnMinesCountChange);
        generationDurationSlider.onValueChanged.AddListener(OnGenerationDurationChange);
        eliteCountSlider.onValueChanged.AddListener(OnEliteCountChange);
        mutationChanceSlider.onValueChanged.AddListener(OnMutationChanceChange);
        mutationRateSlider.onValueChanged.AddListener(OnMutationRateChange);
        hiddenLayersCountSlider.onValueChanged.AddListener(OnHiddenLayersCountChange);
        neuronsPerHLSlider.onValueChanged.AddListener(OnNeuronsPerHLChange);
        biasSlider.onValueChanged.AddListener(OnBiasChange);
        sigmoidSlopeSlider.onValueChanged.AddListener(OnSigmoidSlopeChange);

        populationText = populationCountTxt.text;
        minesText = minesCountTxt.text;
        generationDurationText = generationDurationTxt.text;
        elitesText = eliteCountTxt.text;
        mutationChanceText = mutationChanceTxt.text;
        mutationRateText = mutationRateTxt.text;
        hiddenLayersCountText = hiddenLayersCountTxt.text;
        neuronsPerHLCountText = neuronsPerHLCountTxt.text;
        biasText = biasTxt.text;
        sigmoidSlopeText = sigmoidSlopeTxt.text;

        populationCountSlider.value = popManager.PopulationCount;
        minesCountSlider.value = popManager.MinesCount;
        generationDurationSlider.value = popManager.GenerationDuration;
        eliteCountSlider.value = popManager.EliteCount;
        mutationChanceSlider.value = popManager.MutationChance * 100.0f;
        mutationRateSlider.value = popManager.MutationRate * 100.0f;
        hiddenLayersCountSlider.value = popManager.HiddenLayers;
        neuronsPerHLSlider.value = popManager.NeuronsCountPerHL;
        biasSlider.value = -popManager.Bias;
        sigmoidSlopeSlider.value = popManager.P;
    }

    private void Awake()
    {
        UIController.OnStartButtonClicked += OnStartButtonClick;
    }

    private void OnDestroy()
    {
        UIController.OnStartButtonClicked -= OnStartButtonClick;
    }

    void OnPopulationCountChange(float value)
    {
        popManager.PopulationCount = (int)value;
        
        populationCountTxt.text = string.Format(populationText, popManager.PopulationCount);
    }

    void OnMinesCountChange(float value)
    {
        popManager.MinesCount = (int)value;        

        minesCountTxt.text = string.Format(minesText, popManager.MinesCount);
    }

    void OnGenerationDurationChange(float value)
    {
        popManager.GenerationDuration = (int)value;
        
        generationDurationTxt.text = string.Format(generationDurationText, popManager.GenerationDuration);
    }

    void OnEliteCountChange(float value)
    {
        popManager.EliteCount = (int)value;

        eliteCountTxt.text = string.Format(elitesText, popManager.EliteCount);
    }

    void OnMutationChanceChange(float value)
    {
        popManager.MutationChance = value / 100.0f;

        mutationChanceTxt.text = string.Format(mutationChanceText, (int)(popManager.MutationChance * 100));
    }

    void OnMutationRateChange(float value)
    {
        popManager.MutationRate = value / 100.0f;

        mutationRateTxt.text = string.Format(mutationRateText, (int)(popManager.MutationRate * 100));
    }

    void OnHiddenLayersCountChange(float value)
    {
        popManager.HiddenLayers = (int)value;
        

        hiddenLayersCountTxt.text = string.Format(hiddenLayersCountText, popManager.HiddenLayers);
    }

    void OnNeuronsPerHLChange(float value)
    {
        popManager.NeuronsCountPerHL = (int)value;

        neuronsPerHLCountTxt.text = string.Format(neuronsPerHLCountText, popManager.NeuronsCountPerHL);
    }

    void OnBiasChange(float value)
    {
        popManager.Bias = -value;

        biasTxt.text = string.Format(biasText, popManager.Bias.ToString("0.00"));
    }

    void OnSigmoidSlopeChange(float value)
    {
        popManager.P = value;

        sigmoidSlopeTxt.text = string.Format(sigmoidSlopeText, popManager.P.ToString("0.00"));
    }


    void OnStartButtonClick()
    {
        popManager.StartSimulation();
        this.gameObject.SetActive(false);
        simulationScreen.SetActive(true);
    }

}
