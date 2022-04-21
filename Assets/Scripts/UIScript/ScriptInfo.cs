using System;
using UnityEngine;

[Serializable]
public class ScriptInfo
{
    [SerializeField] private string _script;
    [SerializeField] private string _leftCharacterIconID;
    [SerializeField] private string _rightCharacterIconID;
    [SerializeField] private EAction _onEnterAction;
    [SerializeField] private EAction _onExitAction;

    public string Script { get { return _script; } }
    public string LeftCharacterIconID { get { return _leftCharacterIconID; } }
    public string RightCharacterIconID { get { return _rightCharacterIconID; } }
    public EAction OnEnterAction { get { return _onEnterAction; } }
    public EAction OnExitAction { get { return _onExitAction; } }
}