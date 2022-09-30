
public class ISceneState
{
    private string m_StateName = "ISceneState";

    public string StateName
    {
        get => m_StateName;
        set => m_StateName = value;
    }

    protected SceneStateController m_Controller = null;

    public ISceneState(SceneStateController controller)
    {
        m_Controller = controller;
    }

    public virtual void StateBegin() { }

    public virtual void StateEnd() { }
    public virtual void StateUpdate() { }

    public override string ToString()
    {
        return $"[I_SceneState: StateName={StateName}]";
    }
}
