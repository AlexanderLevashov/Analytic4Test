using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests
{
    public class ParametersForAnalysisTests
    {
        public static string MatPanel_1 { get; } = "По готовности";
        public static string MatPanel_2 { get; } = "В заданное время";
    }

    public class ParametersForProfile
    {
        public static string MatProfile_1 { get; } = "По умолчанию";
    }

    public class ParametersForCheckBoxAnalysis
    {
        public static string Sample { get; } = "Проба";
        public static string Volume { get; } = "Обёъм";
        public static string Appointment { get; } = "Назначение";
        public static string Breeding { get; } = "Разведение";
        public static string Graduationlevel { get; } = "Градуировочный уровень";
        public static string PlaceSelection { get; } = "Место отбора";
        public static string DateSelection { get; } = "Дата отбора";
        public static string Start { get; } = "Старт";
        public static string Comments { get; } = "Комментарии";
    }

    public class ParametersForCheckBoxInstrument
    {
        public static string Channel { get; } = "Каналы";
        public static string TimeAnalysis { get; } = "Время анализа";
        public static string WorkStage { get; } = "Этапы работы";
    }

    public class ParametersForCheckBoxExecutor
    {
        public static string TypeExecutor { get; } = "Тип исполнителя";
        public static string State { get; } = "Режим";
    }

    public class ParametersForProject
    {
        public static string Project { get; } = "test";
    }

    public class ParametersForPanelProject
    {
        public static string Ok { get; } = "Открыть";

        public static string Cancel { get; } = "Отмена";
    }

    public class ParametersForMethod
    {
        public static string Test { get; } = "test";
    }

    public class ParametersForPurpose
    {
        public static string Analysis { get; } = "Анализ";
        public static string Graduation { get; } = "Градуировка";
        public static string BaseLine { get; } = "Базовая линия";
        public static string ControlSample { get; } = "Контрольный образец";
    }

    public class ParametersForGraduationLevel
    {
        public static string Not { get; } = "Нет";
    }

    public class ParametersForState
    {
        public static string Analysis { get; } = "Анализ";
        public static string Graduation { get; } = "Градуировка";
        public static string Control { get; } = "Контрольный образец";
        public static string BaseLine { get; } = "Нулевая линия";
        public static string WithoutName { get; } = "Без записи";
    }

    public class ParametersForStart
    {
        public static string Not { get; } = "Нет";
        public static string Start_1 { get; } = "Старт 1";
        public static string Start_2 { get; } = "Старт 2";
        public static string Start_3 { get; } = "Старт 3";
        public static string Start_4 { get; } = "Старт 4";
        public static string Start_5 { get; } = "Старт 5";
        public static string Start_6 { get; } = "Старт 6";
        public static string Start_7 { get; } = "Старт 7";
        public static string Start_8 { get; } = "Старт 8";

    }
    
}
