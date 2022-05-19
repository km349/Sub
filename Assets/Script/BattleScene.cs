using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : MonoBehaviour
{
    Scene scene;
    Player player;
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        player = gameObject.AddComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name=="Battle")
        {
            if (GameObject.Find(enemy.GetSetEnemyNum))
            {
                gameObject.SetActive(true);
                enemy.GetSetEnemyNum = null;
            }
        }

        if (player.GetSetPlayerHP <= 0)
        {
            scene.ChangeScene((int)Scene.SceneName.GameOver);
            enemy.GetSetEnemyBattleFlg = true;
        }
        if (enemy.GetSetEnemyHP <= 0)
        {
            //scene.ChangeScene((int)Scene.SceneName.GameOver);
            enemy.GetSetEnemyBattleFlg = true;
        }
    }
}
