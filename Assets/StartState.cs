using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : ISceneState
{
    public StartState(SceneStateController controller) : base(controller)
    {
        this.StateName = "StartState";
    }
    public override void StateBegin()
    {

        Debug.Log("初始场景");
    }
    public override void StateUpdate()
    {
        Debug.Log("初始场景Update");
        if (Input.GetMouseButtonDown(0))
            m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuState");
    }
}
