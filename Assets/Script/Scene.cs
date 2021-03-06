using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    private int SceneFlgNum = 0;
    private bool Sceneflg = false;

    public int GetSetSceneFlg
    {
        get { return SceneFlgNum; }
        set { SceneFlgNum = value; }
    }

    public bool GetSetFlgScene
    {
        get { return Sceneflg; }
        set { Sceneflg = value; }
    }

    public enum SceneName
    {
        Title,
        Search01,
        Search02,
        Search03,
        Search04,
        Search05,
        Search06,
        Search07,
        Search08,
        Search09,
        Battle,
        GameClear,
        GameOver,
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Sceneflg)
        {
            // SceneΜ
            switch (SceneFlgNum)
            {
                case 0: // ^CgV[
                    SceneManager.LoadScene("Title"); 
                    break;
                case 1: // TυV[P
                    SceneManager.LoadScene("Search01");
                    break;
                case 2: // TυV[Q
                    SceneManager.LoadScene("Search02"); 
                    break;
                case 3: // TυV[R
                    SceneManager.LoadScene("Search03");
                    break;
                case 4: // TυV[S
                    SceneManager.LoadScene("Search04");
                    break;
                case 5: // TυV[T
                    SceneManager.LoadScene("Search05");
                    break;
                case 6: // TυV[U
                    SceneManager.LoadScene("Search06");
                    break;
                case 7: // TυV[7
                    SceneManager.LoadScene("Search07");
                    break;
                case 8: // TυV[8
                    SceneManager.LoadScene("Search08");
                    break;
                case 9: // TυV[9
                    SceneManager.LoadScene("Search09");
                    break;
                case 10: // ν¬V[
                    SceneManager.LoadScene("Battle"); 
                    break;
                case 11: // Q[NAV[
                    SceneManager.LoadScene("GameClear"); 
                    break;
                case 12: // Q[I[o[V[
                    SceneManager.LoadScene("GameOver"); 
                    break;
            }
            GetSetFlgScene = false;

            // NodeSceneΜ
            if (SceneFlgNum == 1 || SceneFlgNum == 2 || SceneFlgNum == 3 ||
                SceneFlgNum == 4 || SceneFlgNum == 5 || SceneFlgNum == 6 ||
                SceneFlgNum == 7 || SceneFlgNum == 8 || SceneFlgNum == 9 || SceneFlgNum == 10)  
            {
                SceneManager.LoadSceneAsync("Node", LoadSceneMode.Additive);
                GetSetFlgScene = false;
            }
            else if (SceneFlgNum == 8 || SceneFlgNum == 9) 
            {
                SceneManager.UnloadSceneAsync("Node");
                GetSetFlgScene = true;
            }
        }
    }

    public void ChangeScene(int scenenum)
    {
        SceneFlgNum= scenenum;
        Sceneflg = true;
    }
}
