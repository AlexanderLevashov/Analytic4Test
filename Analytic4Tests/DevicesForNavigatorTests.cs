using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests
{
    public class DevicesForNavigatorTests
    {
        public static string SetUpConnection { get; } = "Настроить соединение...";
        public static string LocalServerDevices { get; } = "Локальный сервер приборов";
        public static string EmulatorGCH { get; } = "Эмулятор ГХ";
        public static string EmulatorGCHIsActive { get; } = "Эмулятор ГХ активен:";
    }

    public class EmulatorsForNavigatorTests
    {
        public static string NaturalGas { get; } = "Природный газ";
        public static string GasesOnTransformerOil { get; } = "Газы в трансформаторном масле";
        public static string TraceImpuritiesInVodka { get; } = "Микропримеси в водке";
    }

    public class LogOutForNavigatorTests
    {
        public static string Language { get; } = "Язык (language)";
        public static string Exit { get; } = "Выйти";
    }

    public class LanguageForNavigarorTests
    {
        public static string Russian { get; } = "Русский";
        public static string English { get; } = "English";
        public static string Chinese { get; } = "中國人";
    }

    public class ConnectionWidgestWrapper
    {
        public static string TestConnection { get; } = "Test Connection";
    }
}
