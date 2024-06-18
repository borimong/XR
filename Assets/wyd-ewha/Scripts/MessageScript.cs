using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageScript : MonoBehaviour
{
    public TextMeshProUGUI stageText;
    public TextMeshProUGUI npcCountText;
    
    void Start()
    {
        stageText.text = PlayerPrefs.GetString("StageText");
        npcCountText.text = PlayerPrefs.GetString("NpcCountText");
    }


}
