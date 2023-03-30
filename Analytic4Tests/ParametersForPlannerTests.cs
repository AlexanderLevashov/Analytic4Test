using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests
{
    public class ParametersForPlannerTests
    {
        public static string Settings { get; } = "Настройки";
        public static string Profile { get; } = "Профили";
        public static string AddSeriesAnalysis { get; } = "Добавить серию анализов";
        public static string ShutDown { get; } = "Завершение работы";
    }

    public class SettingsParameters
    {
        public static string DefaultDevice { get; } = "Устройство по умолчанию";
        public static string RetransmittingMode { get; } = "Повторная передача режима";
        public static string RepeatAnalysis { get; } = "Повтор анализа";
    }

    public class SettingsDefaultDevice
    {
        public static string Plagin { get; } = "Без периферии";
    }

    public class SettingsAddAnalysis
    {
        public static string Add_1_Analysis { get; } = "Добавить 1 анализ";
        public static string Add_5_Analysis { get; } = "Добавить 5 анализ";
        public static string Add_n_Analysis { get; } = "Добавить n анализ";
        public static string AddFromBuffer { get; } = "Добавить из буфера обмена";
        public static string SettingMSD { get; } = "Настройка МСД";
    }

    public class Chromatograph
    {
        public static string Ip_address { get; } = "";
        public static string Gateway { get; } = "2010";
        public static string Pressure { get; } = "0";
        public static string Temperature { get; } = "0";
        public static string CommonSubParameters { get; } = "нет";
        public static string CommonParameters_1 { get; } = "нет";
        public static string CommonParameters_2 { get; } = "LastMethod";
        
    }

    public class Column
    {
        public static string TemperatureColumn { get; } = "450";
    }

    public class TCD2
    {
        public static string TCD2Channel_1 { get; } = "Нет";
        public static string TCD2Channel_2 { get; } = "Старт 1";
        public static string TCD2Channel_3 { get; } = "Старт 2";
        public static string TCD2TypeDetector_1 { get; } = "ДТП";
        public static string TCD2TypeDetector_2 { get; } = "ДТП-μ";
        public static string TCD2TypeDetector_3 { get; } = "ДТП-ПЧ";
        public static string TCD2TypeDetector_4 { get; } = "ДТП-КС";
        public static string TCDAcquisitionRate_1 { get; } = "10";
        public static string TCDAcquisitionRate_2 { get; } = "25";
        public static string TCDAcquisitionRate_3 { get; } = "50";
        public static string TCDAcquisitionRate_4 { get; } = "100";
        public static string TCDAcquisitionRate_5 { get; } = "200";
        public static string TCDAcquisitionRate_6 { get; } = "300";
        public static string TCDAcquisitionRate_7 { get; } = "5";
        public static string TCDAcquisitionRate_8 { get; } = "500";
        public static string TCDThermostat_1 { get; } = "Нет";
        public static string TCDThermostat_2 { get; } = "Термостат детекторов 1";
        public static string TCDThermostat_3 { get; } = "Термостат детекторов 2";
        public static string TCDPower_1 { get; } = "25% [азот, аргон]";
        public static string TCDPower_2 { get; } = "100% [гелий, водород]";
        public static string TCDShift { get; } = "0";
    }
}
