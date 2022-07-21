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

public sealed partial class RandomNameConfig :  Bright.Config.BeanBase 
{
    public RandomNameConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        NameBefore = _buf.ReadString();
        NameAfter = _buf.ReadString();
        PostInit();
    }

    public static RandomNameConfig DeserializeRandomNameConfig(ByteBuf _buf)
    {
        return new RandomNameConfig(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名称前缀
    /// </summary>
    public string NameBefore { get; private set; }
    /// <summary>
    /// 名称后缀
    /// </summary>
    public string NameAfter { get; private set; }

    public const int __ID__ = 1869005552;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NameBefore:" + NameBefore + ","
        + "NameAfter:" + NameAfter + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
