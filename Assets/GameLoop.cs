using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    SceneStateController sceneStateController = new SceneStateController();
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);

        Random.seed = (int)System.DateTime.Now.Ticks;
    }
    void Start()
    {
        sceneStateController.SetState(new StartState(sceneStateController), "");
    }

    // Update is called once per frame
    void Update()
    {
        sceneStateController.Stateupdate();
    }
}
