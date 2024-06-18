using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public void LoadOpeningScene() {
        SceneManager.LoadScene("Opening");
        Debug.Log("Opening");
    }
    
    public void LoadTutorialScene() {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Tutorial");
    }

    public void LoadTimeTableScene() {
        SceneManager.LoadScene("TimeTable");
        Debug.Log("Timetable - Stage " + PlayerPrefs.GetInt("Current Stage"));
    }

    public void LoadSchoolMapScene() {

        switch (PlayerPrefs.GetInt("Current Stage"))
        {
            case 1:
                SceneManager.LoadScene("SchoolMap1");
                Debug.Log("SchoolMap - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 2:
                SceneManager.LoadScene("SchoolMap2");
                Debug.Log("SchoolMap - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 3:
                SceneManager.LoadScene("SchoolMap3");
                Debug.Log("SchoolMap - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 4:
                SceneManager.LoadScene("SchoolMap4");
                Debug.Log("SchoolMap - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
        }
        
    }
    
    public void LoadNavigationScene() {
        
        switch (PlayerPrefs.GetInt("Current Stage"))
        {
            case 1:
                SceneManager.LoadScene("Navigation1");
                Debug.Log("Navigation - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 2:
                SceneManager.LoadScene("Navigation2");
                Debug.Log("Navigation - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 3:
                SceneManager.LoadScene("Navigation3");
                Debug.Log("Navigation - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 4:
                SceneManager.LoadScene("Navigation4");
                Debug.Log("Navigation - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
        }
        
    }

    public void LoadCatchNpcScene() {
        
        string currentSceneName = SceneManager.GetActiveScene().name;
        
        switch (PlayerPrefs.GetInt("Current Stage"))
        {
            case 0:
                SceneManager.LoadScene("CatchNpc0");
                Debug.Log("CatchNpc - Stage " + PlayerPrefs.GetInt("Current Stage"));
                break;
            case 1:
                switch (currentSceneName)
                {
                    case "CatchNpc1":
                        SceneManager.LoadScene("CatchNpc2");
                        break;
                    case "CatchNpc2":
                        SceneManager.LoadScene("CatchNpc3");
                        break;
                    default:
                        SceneManager.LoadScene("CatchNpc1");
                        break;
                }

                break;
            case 2:
                switch (currentSceneName)
                {
                    case "CatchNpc4":
                        SceneManager.LoadScene("CatchNpc5");
                        break;
                    case "CatchNpc5":
                        SceneManager.LoadScene("CatchNpc6");
                        break;
                    default:
                        SceneManager.LoadScene("CatchNpc4");
                        break;
                }

                break;
            case 3:
                switch (currentSceneName)
                {
                    case "CatchNpc7":
                        SceneManager.LoadScene("CatchNpc8");
                        break;
                    case "CatchNpc8":
                        SceneManager.LoadScene("CatchNpc9");
                        break;
                    default:
                        SceneManager.LoadScene("CatchNpc7");
                        break;
                }

                break;
            case 4:
                switch (currentSceneName)
                {
                    case "CatchNpc10":
                        SceneManager.LoadScene("CatchNpc11");
                        break;
                    case "CatchNpc11":
                        SceneManager.LoadScene("CatchNpc12");
                        break;
                    default:
                        SceneManager.LoadScene("CatchNpc10");
                        break;
                }

                break;
        }
        
    }
    
    public void LoadInventoryScene() {
        SceneManager.LoadScene("Inventory");
        Debug.Log("Inventory - Stage " + PlayerPrefs.GetInt("Current Stage"));
    }
    
    public void LoadEndingScene() {
        SceneManager.LoadScene("Ending");
        Debug.Log("Ending - Stage " + PlayerPrefs.GetInt("Current Stage"));
    }

}
