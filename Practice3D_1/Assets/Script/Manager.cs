using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int TotalItemCnt;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;


    void Awake()
    {
        stageCountText.text = "/ " + TotalItemCnt;    
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }    
    }
}
