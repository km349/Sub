using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    Scene scene;
    private bool trg;

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && trg)
        {
            scene.ChangeScene((int)Scene.SceneName.Title);
            trg = false;
        }
        trg = true;
    }
}
