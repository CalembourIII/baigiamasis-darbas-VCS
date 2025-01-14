﻿namespace Framework.POM
{
    public class Mokesciu_skaiciuokle
    {
        private static string url = "https://tax.lt/skaiciuokles/atlyginimo_ir_mokesciu_skaiciuokle";
        private static string acceptCookiesLocator = "//div[@class='fc-footer-buttons']//button[@aria-label='Sutikimas']";

        private static string selectYearDropDownLocator = "//*[@id='mokestiniai_metai']";

        private static string radioButtonIRankasLocator = "//*[@id='koks_atl_2']";
        private static string enterSalaryLocator = "//*[@id='atlyginimas']";

        private static string radioButtonPaskaiciuosSistemaLocator = "//*[@id='paskaiciuoti_npd_1']";
        private static string radioButtonNurodysiuPatsLocator = "//*[@id='paskaiciuoti_npd_2']";
        private static string enterNpdLocator = "//*[@id='taikomas_npd']";

        private static string checkboxKaupiuPensijaiPapildomaiLocator = "//*[@id='papildomas_pensijos_kaupimas']";

        private static string valuePajamuMokestisLocator = "//*[@id='paj_mok']";
        private static string valueIsmokamasAtlyginimasIRankasLocator = "//*[@id='i_rankas']";
        private static string valueVisaDarboVietosKainaLocator = "//*[@id='darb_kaina']";

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.ClickElement(acceptCookiesLocator);
        }

        public static void SelectYear(string year)
        {
            Common.SelectOptionByValue(selectYearDropDownLocator, year);
        }

        public static void ClickRadioButtonIRankas()
        {
            Common.ClickElement(radioButtonIRankasLocator);
        }

        public static void EnterSalary(string salary)
        {
            Common.SendKeysToElement(enterSalaryLocator, salary);
        }

        public static void ClickRadioButtonPaskaiciuosSistema()
        {
            Common.ClickElement(radioButtonPaskaiciuosSistemaLocator);
        }

        public static void ClickRadioButtonNurodysiuPats()
        {
            Common.ClickElement(radioButtonNurodysiuPatsLocator);
        }

        public static void ClearPreEnteredNpdValue()
        {
            Common.ClearInputElement(enterNpdLocator);
        }

        public static void EnterNpd(string npd)
        {
            Common.SendKeysToElement(enterNpdLocator, npd);
        }

        public static void ClickCheckboxKaupiuPensijaiPapildomai()
        {
            Common.ClickElement(checkboxKaupiuPensijaiPapildomaiLocator);
        }

        public static string GetValuePajamuMokestis()
        {
            return Common.GetElementText(valuePajamuMokestisLocator);
        }

        public static string GetValueAtlyginimasIRankas()
        {
            return Common.GetElementText(valueIsmokamasAtlyginimasIRankasLocator);
        }

        public static string GetValueVisaDarboVietosKaina()
        {
            return Common.GetElementText(valueVisaDarboVietosKainaLocator);
        }

        public static bool WaitForFullValueToAppear(string value)
        {
            return Common.WaitForFullValue(valuePajamuMokestisLocator, value);
        }
    }
}
