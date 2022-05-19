using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ゲーム開始直後のシーン読み込み前に呼ばれるようにする属性を指定
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void InitializeBeforeSceneLoad()
    {
        // Resources内のGameManagerプレハブを読み込み
        var gameManagerPrefab = Resources.Load<GameManager>("GameManager");

        // ゲーム中に常に存在するオブジェクトを生成
        var gameManager = Instantiate(gameManagerPrefab);
        // シーン変更時にも破棄されないようにする
        DontDestroyOnLoad(gameManager);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }
}
