using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests
{
    public class ParametersForControlPanelTests
    {

        //public static string ConnectToDevice { get; } = "Подключиться к выбранному прибору";

    }


    public class NumberChannel
    {
        public static string ChannelStart1 { get; } = "1";

        public static string ChannelStart2 { get; } = "2";

        public static string ChannelStart3 { get; } = "3";

        public static string ChannelStart4 { get; } = "4";

    }

    public class NameDevices
    {
        public static string PM3 { get; } = "ПМ3";

        public static string PM2 { get; } = "ПМ2";

        public static string MSDv1 { get; } = "МСД v1";

        public static string MSD { get; } = "МСД";

        public static string FLD { get; } = "ФЛД";

        public static string SpectrDetector { get; } = "Спектрофотометрический детектор";

        public static string GradientNDPump { get; } = "Насос градиентный НД";

        public static string GradientVDPump { get; } = "Насос градиентный ВД";

        public static string IsocraticPump { get; } = "Насос изократический";

        public static string DiodeMatrixDetector { get; } = "Диодно матричный детектор";

        public static string ColumnThermostat { get; } = "Термостат колонок";

        public static string DualConductometricDetector { get; } = "Сдвоенный кондуктометрический детектор";

        public static string AnalyticalPump214_5_883_04X { get; } = "Насос аналитический 214.5.883.04X";

        public static string ColumnThermostat214_5_868_052 { get; } = "Термостат колонок 214.5.868.052";

        public static string ConductometricDetector { get; } = "Кондуктометрический детектор";

        public static string TDA { get; } = "ТДА";

        public static string PAL { get; } = "PAL";

        public static string DALUsual { get; } = "ДАЖ ВЭЖХ";

        public static string DALVaporPhase { get; } = "ДАЖ парофазный";

        public static string DAL { get; } = "ДАЖ";
    }

    public class NameChannels
    {
        public static string Start_1 { get; } = "Старт - 1";

        public static string Start_2 { get; } = "Старт - 2";
    }

    public class NameConnection
    {
        public static string TCP { get; } = "TCP";

        public static string COM { get; } = "COM";
    }

    #region IP адреса
    public class Adress_127_0_0_1
    {
        public static string Octet0 { get; } = "127";
        public static string Octet1 { get; } = "0";
        public static string Octet2 { get; } = "0";
        public static string Octet3 { get; } = "1";
    }

    public class Adress_192_168_0_41
    {
        public static string Octet0 { get; } = "192";
        public static string Octet1 { get; } = "168";
        public static string Octet2 { get; } = "0";
        public static string Octet3 { get; } = "41";
    }

    public class Adress_192_168_77_89
    {
        public static string Octet0 { get; } = "192";
        public static string Octet1 { get; } = "168";
        public static string Octet2 { get; } = "77";
        public static string Octet3 { get; } = "89";
    }

    #endregion

    public class Port
    {
        public static string Port2010 { get; set; } = "2010";
    }

    public class Alert
    {
        public static string Ok { get; } = "Хорошо";

        public static string Cancel { get; } = "Отмена";
    }

}
