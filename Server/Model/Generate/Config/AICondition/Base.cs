//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace ET.AICondition
{

public abstract partial class Base :  Bright.Config.BeanBase 
{
    public Base(ByteBuf _buf) 
    {
        PostInit();
    }

    public static Base DeserializeBase(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case AICondition.None.__ID__: return new AICondition.None(_buf);
            case AICondition.PickSingle.__ID__: return new AICondition.PickSingle(_buf);
            case AICondition.PickMulti.__ID__: return new AICondition.PickMulti(_buf);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
