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
        var datas = new RankData();
        Refresh(datas.RankItemDatas[0]);
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

    private void SetData(RankItemData data)
    {
        
        _imageBg.sprite = Resources.Load<Sprite>(data.ImageBg);
        _tfUp.gameObject.SetActive(data.IsUp);
        _tfDown.gameObject.SetActive(data.IsDown);
        _textNo.text = data.TextNo;
        _textName.text = data.TextName;
        _textRankInfo.text = data.TextRankInfo;
        _buttonInfo.onClick.AddListener(TestClick);
        _textScore.text = data.TextScore;
        
    }

    public void Refresh(RankItemData data)
    {
        Init();
        SetData(data);
    }

    public void TestClick()
    {
        Debug.Log("!!!!!!!!!!!!!!!");
    }
}
