//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace ET.StartServer
{

public sealed partial class StartScene :  Bright.Config.BeanBase 
{
    public StartScene(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Process = _buf.ReadInt();
        Zone = _buf.ReadInt();
        SceneType = (ET.SceneType)_buf.ReadInt();
        Name = _buf.ReadString();
        OuterPort = _buf.ReadInt();
        PostInit();
    }

    public static StartScene DeserializeStartScene(ByteBuf _buf)
    {
        return new StartServer.StartScene(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 所属进程
    /// </summary>
    public int Process { get; private set; }
    /// <summary>
    /// 所属区
    /// </summary>
    public int Zone { get; private set; }
    /// <summary>
    /// 类型
    /// </summary>
    public ET.SceneType SceneType { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 外网端口
    /// </summary>
    public int OuterPort { get; private set; }

    public const int __ID__ = 1690877139;
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
        + "Process:" + Process + ","
        + "Zone:" + Zone + ","
        + "SceneType:" + SceneType + ","
        + "Name:" + Name + ","
        + "OuterPort:" + OuterPort + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
