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

public sealed partial class AttributeInfo :  Bright.Config.BeanBase 
{
    public AttributeInfo(ByteBuf _buf) 
    {
        NumericType = (NumericType)_buf.ReadInt();
        Formula = _buf.ReadString();
        PostInit();
    }

    public static AttributeInfo DeserializeAttributeInfo(ByteBuf _buf)
    {
        return new AttributeInfo(_buf);
    }

    /// <summary>
    /// 数值类型
    /// </summary>
    public NumericType NumericType { get; private set; }
    /// <summary>
    /// 公式
    /// </summary>
    public string Formula { get; private set; }

    public const int __ID__ = -650443446;
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
        + "NumericType:" + NumericType + ","
        + "Formula:" + Formula + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
