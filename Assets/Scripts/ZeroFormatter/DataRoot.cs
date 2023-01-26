using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeroFormatter;
using ZeroFormatter.Segments;

[ZeroFormattable]
public class DataRoot
{
    public enum DataType
    {
        Stage1,
        Stage2,
        Stage3,
        Stage4,
        Stage5,
        Stage6
    }


    [Index(0)]
    public virtual DataType Type { get; set; }

}
