using UnityEngine;

public class GameManager : MonoBehaviour
{
     private string[] stageName = { "정문", "ECC", "대강당", "학관", "중앙도서관" };
     
     public void ResetStage()
     {
         SetStageNum(0);
         ResetNpcLog();
     }

     public void NextStage()
     {
         SetStageNum(PlayerPrefs.GetInt("Current Stage") + 1);
         PlayerPrefs.SetString("NpcCountText", "");
     }
     
     private void SetStageNum(int num)
     {
         PlayerPrefs.SetInt("Current Stage", num);
         SetStageText(num);
     }
     private void SetStageText(int num)
     {
         PlayerPrefs.SetString("StageText", "Stage " + num + " : " + stageName[num]);
         Debug.Log("Stage Text 설정 - " + PlayerPrefs.GetString("StageText"));
     }

     private void ResetNpcLog()
     {
         PlayerPrefs.SetInt("NPCforStage0", 0);
         PlayerPrefs.SetInt("NPCforStage1", 0);
         PlayerPrefs.SetInt("NPCforStage2", 0);
         PlayerPrefs.SetInt("NPCforStage3", 0);
         PlayerPrefs.SetInt("NPCforStage4", 0);
         
         PlayerPrefs.SetString("NpcCountText", "");

     }
    
}
