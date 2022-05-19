using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGeneration : MonoBehaviour
{
    [SerializeField]
    GameObject nodes;

    [SerializeField]
    GameObject canvas;

    private float interval = 1.0f;
    private float timeElapsed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= interval)
        {
            GameObject Nod = (GameObject)Instantiate(nodes);
            Nod.transform.SetParent(canvas.transform, false);
            timeElapsed = 0.0f;
        }
    }
}
