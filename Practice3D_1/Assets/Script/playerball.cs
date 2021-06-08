using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerball : MonoBehaviour
{
    public int itemCnt;
    public float Jpower;
    public Manager manager;
    bool isJump;
    Rigidbody rigid; // ����
    AudioSource audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, Jpower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCnt++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCnt);
        }
        else if (other.tag == "goal")
        {
            if (itemCnt == manager.TotalItemCnt)
            {
                if (manager.stage == 2)
                {
                    // ù���������� ����
                    SceneManager.LoadScene(0);
                }
                else
                {
                    // Ŭ���� �� ���� ��������
                    // SceneManager.LoadScene("example2");
                    SceneManager.LoadScene(manager.stage + 1);
                }
            }
            else
            {
                // �����
                // SceneManager.LoadScene("example1");
                SceneManager.LoadScene(manager.stage);
            }
        }


    }
}
