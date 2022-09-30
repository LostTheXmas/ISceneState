using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneStateController
{
    private ISceneState m_State;
    private bool m_bRunBegin = false;

    public SceneStateController() { }

    public void SetState(ISceneState state,string LoadSceneName)
    {
        m_bRunBegin = false;
        LoadScene(LoadSceneName);
        if (m_State != null)
            m_State.StateEnd();

        m_State = state;
    }
    private void LoadScene(string loadSceneName)
    {
        if (string.IsNullOrEmpty(loadSceneName))
        {
            return;
        }
        SceneManager.LoadScene(loadSceneName);
    }
    public void Stateupdate()
    {
        if(m_State != null&& m_bRunBegin == false)
        {
            m_State.StateBegin();
            m_bRunBegin = true;
        }
        if(m_State != null)
        {
            m_State.StateUpdate();
        }
    }
}
