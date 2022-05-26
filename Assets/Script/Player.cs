using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Scene scene;
    RectTransform rect;
    SearchField search;
    public Slider slider;
    public Rigidbody2D rigidBody;

    private static int currentHP=10;
    private static int playerMoveY = 100;
    private static int playerMoveX = 100;

    private bool trg;
    private bool StageTrg = true;



    Vector3 currentPos;

    public int GetSetPlayerHP
    { 
        get { return currentHP; }
        set { currentHP = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        search = gameObject.AddComponent<SearchField>();
        rect = gameObject.GetComponent<RectTransform>();
        rigidBody = gameObject.GetComponent<Rigidbody2D>();

        // Sliderを満タン
        slider.value = currentHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name== "Battle")
        {
            PlayerBattle();
        }
        if (StageTrg)
        {
            PlayerMove();
        }
        if (!StageTrg) 
        {
            rect.position = currentPos;
        }
    }

    private void PlayerBattle()
    {
        if (Input.GetKeyDown(KeyCode.Space) && trg)
        {
            // ダメージランダム
            int damage = 1;

            // HPからダメージを引く
            currentHP -= damage;

            trg = false;
        }
        slider.value = currentHP;
        trg = true;
    }

    private void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rect.localPosition += new Vector3(-playerMoveX, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rect.localPosition += new Vector3(0, playerMoveY, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rect.localPosition += new Vector3(0, -playerMoveY, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rect.localPosition += new Vector3(playerMoveX, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Stairs"))
        {
            search.GetSetNextFlg = true;
        }
        if (other.gameObject.CompareTag("Stage"))
        {
            StageTrg = true;
            currentPos = rect.position;
        }
        if (other.gameObject.CompareTag("Tile"))
        {
            StageTrg = false;
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
