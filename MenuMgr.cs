using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameOver;
    public GameObject gameOverPanel;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
        }
    }
    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "hurdle")
        {
            MenuMgr.gameOver = true;
        }
    }
}
