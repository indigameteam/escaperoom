using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private List<ScriptInfo> _textInfoList;

    [SerializeField]
    private Text _script;
    [SerializeField]
    private GameObject _backGroundPanel;
    [SerializeField]
    private Image _leftCharacter;
    [SerializeField]
    private Image _rightCharacter;

    private ResourceManager _resMgr;

    void Awake()
    {
        _resMgr = GameObject.Find("ResourceManager").GetComponent<ResourceManager>();

        ScriptInfo curText = _textInfoList[0];
        _script.text = curText.Script;
        Sprite temp = _resMgr.GetResource(curText.LeftCharacterIconID) as Sprite;
        _leftCharacter.sprite = temp;
        temp = _resMgr.GetResource(curText.RightCharacterIconID) as Sprite;
        _rightCharacter.sprite = temp;
    }

    void Update()
    {
        
    }
}
