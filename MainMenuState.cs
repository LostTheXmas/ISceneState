using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateController controller) : base(controller)
    {
        this.StateName = "MainMenuState";
    }
    public override void StateBegin()
    {
        Debug.Log("第二场景");
    }
    public override void StateUpdate()
    {
        Debug.Log("第二场景Update");
        //m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
    }
}
