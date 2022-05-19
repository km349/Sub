using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Scene scene;
    Player player;

    private bool trg;

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        player = gameObject.AddComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && trg)
        {
            scene.ChangeScene((int)Scene.SceneName.Title);
            player.GetSetPlayerHP = 10;
            trg = false;
        }
        trg = true;
    }
}
