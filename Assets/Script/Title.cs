using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    Scene scene;
    private bool trig;

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && trig)
        {
            scene.ChangeScene((int)Scene.SceneName.Search01);
            trig = false;
        }
        trig = true;
    }
}
