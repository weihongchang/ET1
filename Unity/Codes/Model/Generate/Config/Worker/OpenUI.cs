//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace ET.Worker
{

public sealed partial class OpenUI :  Base 
{
    public OpenUI(ByteBuf _buf)  : base(_buf) 
    {
        UiType = (FGUIType)_buf.ReadInt();
        PostInit();
    }

    public static OpenUI DeserializeOpenUI(ByteBuf _buf)
    {
        return new Worker.OpenUI(_buf);
    }

    public FGUIType UiType { get; private set; }

    public const int __ID__ = -1662719282;
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
        + "UiType:" + UiType + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
