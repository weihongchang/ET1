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

public sealed partial class SystemConfig :  Bright.Config.BeanBase 
{
    public SystemConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        About = _buf.ReadString();
        BtnText = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Workers = new System.Collections.Generic.List<Worker.Base>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { Worker.Base _e0;  _e0 = Worker.Base.DeserializeBase(_buf); Workers.Add(_e0);}}
        PostInit();
    }

    public static SystemConfig DeserializeSystemConfig(ByteBuf _buf)
    {
        return new SystemConfig(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 简介
    /// </summary>
    public string About { get; private set; }
    /// <summary>
    /// 按钮文本
    /// </summary>
    public string BtnText { get; private set; }
    /// <summary>
    /// 按钮事件
    /// </summary>
    public System.Collections.Generic.List<Worker.Base> Workers { get; private set; }

    public const int __ID__ = -986474895;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Workers) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Workers) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "About:" + About + ","
        + "BtnText:" + BtnText + ","
        + "Workers:" + Bright.Common.StringUtil.CollectionToString(Workers) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
