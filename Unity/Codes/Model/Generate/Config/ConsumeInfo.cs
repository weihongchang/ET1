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

public sealed partial class ConsumeInfo :  Bright.Config.BeanBase 
{
    public ConsumeInfo(ByteBuf _buf) 
    {
        Type = (ConsumeType)_buf.ReadInt();
        Param = _buf.ReadInt();
        Value = _buf.ReadInt();
        PostInit();
    }

    public static ConsumeInfo DeserializeConsumeInfo(ByteBuf _buf)
    {
        return new ConsumeInfo(_buf);
    }

    public ConsumeType Type { get; private set; }
    public int Param { get; private set; }
    public int Value { get; private set; }

    public const int __ID__ = 808263338;
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
        + "Type:" + Type + ","
        + "Param:" + Param + ","
        + "Value:" + Value + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
