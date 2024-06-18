using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class NpcManager : MonoBehaviour
{
    private ObserverBehaviour mObserverBehaviour;
    
    public Button npcInfoButton;
    public TextMeshProUGUI npcCountText;

    void Start()
    {
        
        npcInfoButton.onClick.AddListener(OnNPCInfoButtonClick);

        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        
        if (status.Status == Status.TRACKED | status.Status == Status.EXTENDED_TRACKED & npcInfoButton.interactable != true)
        {
            npcInfoButton.interactable = true;
        }
    }

    public void OnNPCInfoButtonClick()
    {
        npcInfoButton.interactable = false;
        
        int stage = PlayerPrefs.GetInt("Current Stage");
        int npcCount = PlayerPrefs.GetInt("NPCforStage" + stage) + 1;
        
        PlayerPrefs.SetInt("NPCforStage" + stage, npcCount);
        PlayerPrefs.SetString("NpcCountText", "찾은 이화인 : " + npcCount + "명");
        
        npcCountText.text = "찾은 이화인 : " + npcCount + "명";
    }
    
}