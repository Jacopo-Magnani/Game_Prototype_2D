using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorFunction : MonoBehaviour
{
    [SerializeField]
    public int level;

    private string player_tag = "Player";

    public void LoadLevel(int x) {
        SceneManager.LoadScene(x);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag(player_tag))
        {
            //if (Input.GetKeyUp(KeyCode.W)) 
            //{
                SceneManager.LoadScene(level);
            //}
        }
    }
}
