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
        enemy = gameObject.AddComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetSetPlayerHP <= 0)
        {
            scene.ChangeScene((int)Scene.SceneName.GameOver);
        }
        if (enemy.GetSetEnemyHP <= 0)
        {
            scene.ChangeScene((int)Scene.SceneName.GameClear);
        }
    }
}
