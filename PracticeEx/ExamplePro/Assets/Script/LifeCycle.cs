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
            Debug.Log("anyKeyDown. �÷��̾ �ƹ� Ű�� �������ϴ�");
        if (Input.anyKey)
            Debug.Log("anyKey. �÷��̾ �ƹ� Ű�� �������ϴ�");
    }
}
