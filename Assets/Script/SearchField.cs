using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchField : MonoBehaviour
{
    Scene scene;
    Enemy enemy;
    private bool trg;
    private bool nextScene = false;

    public bool GetSetNextFlg
    {
        get { return nextScene; }
        set { nextScene = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        enemy = gameObject.AddComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        SceneTransition();
    }

    // ÉVÅ[Éìä÷åW
    private void SceneTransition()
    {
        if (SceneManager.GetActiveScene().name == "Search01" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search02);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search02"&&nextScene)
        {
            scene.ChangeScene((int)Scene.SceneName.Search03);
            nextScene = false;
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    scene.ChangeScene((int)Scene.SceneName.Battle);
            //}
        }
        if (SceneManager.GetActiveScene().name == "Search03")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search04);
                trg = false;
            }
            trg = true;
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    scene.ChangeScene((int)Scene.SceneName.Battle);
            //}
        }
        if (SceneManager.GetActiveScene().name == "Search04")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search05);
                trg = false;
            }
            trg = true;
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    scene.ChangeScene((int)Scene.SceneName.Battle);
            //}
        }
        if (SceneManager.GetActiveScene().name == "Search05")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search06);
                trg = false;
            }
            trg = true;
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    scene.ChangeScene((int)Scene.SceneName.Battle);
            //}
        }
        if (SceneManager.GetActiveScene().name == "Search06")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search07);
                trg = false;
            }
            trg = true;
        }
        if (SceneManager.GetActiveScene().name == "Search07")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search08);
                trg = false;
            }
            trg = true;
        }
        if (SceneManager.GetActiveScene().name == "Search08")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.Search09);
                trg = false;
            }
            trg = true;
        }
        if (SceneManager.GetActiveScene().name == "Search09")
        {
            if (Input.GetKeyDown(KeyCode.Return) && trg)
            {
                scene.ChangeScene((int)Scene.SceneName.GameClear);
                trg = false;
            }
            trg = true;
        }

        //if (scene.GetSetSceneFlg == 1 || scene.GetSetSceneFlg == 2 || scene.GetSetSceneFlg == 3 ||
        //    scene.GetSetSceneFlg == 4 || scene.GetSetSceneFlg == 5 || scene.GetSetSceneFlg == 6 ||
        //    scene.GetSetSceneFlg == 7 || scene.GetSetSceneFlg == 8 || scene.GetSetSceneFlg == 9 && enemy.GetSetEnemyBattleFlg) 
        //{
        //    scene.ChangeScene((int)Scene.SceneName.Battle);
        //    enemy.GetSetEnemyBattleFlg = false;
        //}
    }
}
