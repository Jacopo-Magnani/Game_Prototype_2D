using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LevelSelect() {
        SceneManager.LoadScene("MenuStage");
    }

    public void AchievementMenu() {
        SceneManager.LoadScene("MenuAchievement");

    }
    public void MainMenu() {
        SceneManager.LoadScene("MenuMain");
    }

    public void Tutorial1() { 
        SceneManager.LoadScene("Tutorial 1");
    }

    public void Tutorial2() {
        SceneManager.LoadScene("Tutorial 2");
    }

    public void Tutorial3() {
        SceneManager.LoadScene("Tutorial 3");
    }

    public void Level1() {
        SceneManager.LoadScene("Level 1");
    }
    
    public void Level2() {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3() {
        SceneManager.LoadScene("Level 3");
    } 
}
