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
        Debug.Log("�ڶ�����");
    }
    public override void StateUpdate()
    {
        Debug.Log("�ڶ�����Update");
        //m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
    }
}
