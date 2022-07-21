//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace ET.MetaBuffMechanism
{

public sealed partial class AreaDamage :  Base 
{
    public AreaDamage(ByteBuf _buf)  : base(_buf) 
    {
        TargetNum = _buf.ReadInt();
        Formula = _buf.ReadString();
        PostInit();
    }

    public static AreaDamage DeserializeAreaDamage(ByteBuf _buf)
    {
        return new MetaBuffMechanism.AreaDamage(_buf);
    }

    /// <summary>
    /// 伤害量
    /// </summary>
    public int TargetNum { get; private set; }
    /// <summary>
    /// 目标数量
    /// </summary>
    public string Formula { get; private set; }

    public const int __ID__ = -2078143383;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "TargetNum:" + TargetNum + ","
        + "Formula:" + Formula + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
