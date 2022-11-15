using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("anyKeyDown. 플레이어가 아무 키를 눌렀습니다");
        if (Input.anyKey)
            Debug.Log("anyKey. 플레이어가 아무 키를 눌렀습니다");
    }
}
