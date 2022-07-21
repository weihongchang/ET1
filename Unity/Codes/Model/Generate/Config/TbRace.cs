//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace ET
{
   
public partial class TbRace
{
    private readonly Dictionary<int, RaceConfig> _dataMap;
    private readonly List<RaceConfig> _dataList;
    
    public TbRace(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, RaceConfig>();
        _dataList = new List<RaceConfig>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            RaceConfig _v;
            _v = RaceConfig.DeserializeRaceConfig(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, RaceConfig> DataMap => _dataMap;
    public List<RaceConfig> DataList => _dataList;

    public RaceConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public RaceConfig Get(int key) => _dataMap[key];
    public RaceConfig this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}