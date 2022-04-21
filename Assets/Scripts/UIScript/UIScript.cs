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
        _leftCharacter.sprite = Instantiate((Sprite)_resMgr.GetResource(curText.LeftCharacterIconID));
        _rightCharacter.sprite = Instantiate((Sprite)_resMgr.GetResource(curText.RightCharacterIconID));
    }

    void Update()
    {
        
    }
}
