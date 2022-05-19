using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private static int currentHP = 10;
    public Slider slider;
    public Rigidbody2D rigidBody;

    private bool trg;
    private string EnemyNam;
    private bool BattleFlg;

    public string GetSetEnemyNum
    {
        get { return EnemyNam; }
        set { EnemyNam = value; }
    }

    public int GetSetEnemyHP
    {
        get { return currentHP; }
        set { currentHP = value; }
    }

    public bool GetSetEnemyBattleFlg
    {
        get { return BattleFlg; }
        set { BattleFlg = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        // Sliderを満タン
        slider.value = currentHP;

        Debug.Log(EnemyNam);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyBattle();
    }

    private void EnemyBattle()
    {
        if (Input.GetKeyDown(KeyCode.Return) && trg)
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
}
