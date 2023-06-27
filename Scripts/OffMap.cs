using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffMap : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.CompareTag("Out")) 
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
