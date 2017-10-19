using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RankItemView : MonoBehaviour
{
    private Image _imageBg;
    private Transform _tfUp;
    private Transform _tfDown;
    private Text _textNo;
    private Text _textName;
    private Text _textRankInfo;
    private Button _buttonInfo;
    private Text _textScore;

    // Use this for initialization
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Init()
    {
        _imageBg = transform.Find("ImageBg").GetComponent<Image>();
        _tfUp = transform.Find("UpOrDown/ImageUp");
        _tfDown = transform.Find("UpOrDown/ImageDown");
        _textNo = transform.Find("TextNo").GetComponent<Text>();
        _textName = transform.Find("TextName").GetComponent<Text>();
        _textRankInfo = transform.Find("TextRankInfo").GetComponent<Text>();
        _buttonInfo = transform.Find("ButtonInfo").GetComponent<Button>();
        _textScore = transform.Find("TextScore").GetComponent<Text>();
    }

    public void SetData

}
