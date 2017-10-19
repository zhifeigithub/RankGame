using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankData
{
    public List<RankItemData> RankItemDatas;
    public RankData()
    {
        RankItemDatas = new List<RankItemData>();
        var tmp = new RankItemData();
        tmp.ImageBg = "ImageBg";
        tmp.IsDown = false;
        tmp.IsUp = true;
        tmp.TextName = "李四";
        tmp.TextNo = "11";
        tmp.TextRankInfo = "你上升了5个名额";
        tmp.TextScore = "1111";
        RankItemDatas.Add(tmp);
    }

    
    
}
