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

        Debug.Log("��ʼ����");
    }
    public override void StateUpdate()
    {
        Debug.Log("��ʼ����Update");
        if (Input.GetMouseButtonDown(0))
            m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuState");
    }
}
