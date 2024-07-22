using System.ComponentModel;

namespace InstrumentInformation.Models.Entity.Enums;

public enum InstrumentTypeEnum
{
    #region 内窥镜

    [Description("荧光内窥镜9L")]
    Endoscope9L = 47,

    [Description("荧光内窥镜9S")]
    Endoscope9S = 48,

    [Description("电子腹腔镜")]
    ElectronicLaparoscope = 49,

    [Description("单孔电子腹腔镜")]
    SingleElectronicLaparoscope = 59,

    #endregion

    #region 大号持针钳

    [Description("大号持针钳490")]
    LargeNeedleHolder490 = 65,

    [Description("大号持针钳520")]
    LargeNeedleHolder520 = 66,

    [Description("大号持针钳550")]
    LargeNeedleHolder550 = 67,

    #endregion

    #region 特大号持针钳

    [Description("特大号持针钳490")]
    ExtraLargeNeedleHolder490 = 68,

    [Description("特大号持针钳520")]
    ExtraLargeNeedleHolder520 = 69,

    [Description("特大号持针钳550")]
    ExtraLargeNeedleHolder550 = 70,

    #endregion

    #region 大力抓取钳

    [Description("大力抓取钳500")]
    StrongForceps500 = 71,

    [Description("大力抓取钳530")]
    StrongForceps530 = 72,

    [Description("大力抓取钳560")]
    StrongForceps560 = 73,

    #endregion

    #region 圆头抓取钳

    [Description("圆头抓取钳500")]
    RoundTipForceps500 = 74,

    [Description("圆头抓取钳530")]
    RoundTipForceps530 = 75,

    [Description("圆头抓取钳560")]
    RoundTipForceps560 = 76,

    #endregion

    #region 直剪刀

    [Description("直剪刀490")]
    StraightScissors490 = 77,

    [Description("直剪刀520")]
    StraightScissors520 = 78,

    [Description("直剪刀550")]
    StraightScissors550 = 79,

    #endregion

    #region 弯剪刀

    [Description("弯剪刀490")]
    CurvedScissors490 = 80,

    [Description("弯剪刀520")]
    CurvedScissors520 = 81,

    [Description("弯剪刀550")]
    CurvedScissors550 = 82,

    #endregion

    #region 单极弧剪

    [Description("单极弧剪490")]
    MonopolarCurvedScissors490 = 83,

    [Description("单极弧剪520")]
    MonopolarCurvedScissors520 = 84,

    [Description("单极弧剪550")]
    MonopolarCurvedScissors550 = 85,

    #endregion

    #region 单极电钩

    [Description("单极电钩490")]
    MonopolarElectricHook490 = 86,

    [Description("单极电钩520")]
    MonopolarElectricHook520 = 87,

    [Description("单极电钩550")]
    MonopolarElectricHook550 = 88,

    #endregion

    #region 单极电铲

    [Description("单极电铲500")]
    MonopolarElectricShovel500 = 89,

    [Description("单极电铲530")]
    MonopolarElectricShovel530 = 90,

    [Description("单极电铲560")]
    MonopolarElectricShovel560 = 91,

    #endregion

    #region 双极尖头抓钳

    [Description("双极尖头抓钳500")]
    BipolarSharpTipForceps500 = 92,

    [Description("双极尖头抓钳530")]
    BipolarSharpTipForceps530 = 93,

    [Description("双极尖头抓钳560")]
    BipolarSharpTipForceps560 = 94,

    #endregion

    #region 双极圆头抓钳

    [Description("双极圆头抓钳500")]
    BipolarRoundTipForceps500 = 95,

    [Description("双极圆头抓钳530")]
    BipolarRoundTipForceps530 = 96,

    [Description("双极圆头抓钳560")]
    BipolarRoundTipForceps560 = 97,

    #endregion

    #region 超声刀头

    [Description("超声刀头550")]
    UltrasonicKnifeHead550 = 98,

    [Description("超声刀头510")]
    UltrasonicKnifeHead510 = 99,

    #endregion
}