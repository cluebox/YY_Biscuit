using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SpssLib.DataReader;
using SpssLib.SpssDataset;
using System.Data.SqlClient;

namespace YYBiscuit
{
    class YY_Biscuit
    {
        static void Main(string[] args)
        {
            int SurveyID = 600488;
            //string SurveyPeriod = "2014-09-30";//survey period
            string SurveyPeriod = "2018-12-31";
            string Country = "INDONESIA";//survey country
            Biscuit_insertion iobj = new Biscuit_insertion();
           string questions = "iobs,r8,weight,r124a,r124d,r124c,r25c,r1,r7,r12,r2,r124e_39,r124e_105,r124e_116,r124e_40,r124e_106,r124e_42,r124e_140,r124e_6,r124e_114,r124e_7,r124e_8,r124e_9,r124e_10,r124e_118,r124e_143,r124e_157,r124e_164,r124e_166,r124b_39,r124b_105,r124b_116,r124b_40,r124b_106,r124b_42,r124b_140,r124b_6,r124b_114,r124b_7,r124b_8,r124b_9,r124b_10,r124b_118,r124b_143,r124b_157,r124b_164,r124b_166,r126a_39,r126a_105,r126a_116,r126a_40,r126a_106,r126a_42,r126a_140,r126a_6,r126a_114,r126a_7,r126a_8,r126a_9,r126a_10,r126a_118,r126a_143,r126a_157,r126a_164,r126a_166,r126b_39,r126b_105,r126b_116,r126b_40,r126b_106,r126b_42,r126b_140,r126b_6,r126b_114,r126b_7,r126b_8,r126b_9,r126b_10,r126b_118,r126b_143,r126b_157,r126b_164,r126b_166,r25b_39,r25b_105,r25b_116,r25b_40,r25b_106,r25b_42,r25b_140,r25b_6,r25b_114,r25b_7,r25b_8,r25b_9,r25b_10,r25b_118,r25b_143,r25b_157,r25b_164,r25b_166,r25a_39,r25a_105,r25a_116,r25a_40,r25a_106,r25a_42,r25a_140,r25a_6,r25a_114,r25a_7,r25a_8,r25a_9,r25a_10,r25a_118,r25a_143,r25a_157,r25a_164,r25a_166,r124ax_7,r124ax_13,r124ax_19,r124ax_20,r124ax_25,r124bx_7,r124bx_13,r124bx_19,r124bx_20,r124bx_25,r126ax_7,r126ax_13,r126ax_19,r126ax_20,r126ax_25,r124dx_7,r124dx_13,r124dx_19,r124dx_20,r124dx_25,r124ex_7,r124ex_13,r124ex_19,r124ex_20,r124ex_25,r126bx_7,r126bx_13,r126bx_19,r126bx_20,r126bx_25,r124cx_7,r124cx_13,r124cx_19,r124cx_20,r124cx_25,r25cx_7,r25cx_13,r25cx_19,r25cx_20,r25cx_25,r25ax_7,r25ax_13,r25ax_19,r25ax_20,r25ax_25,r25bx_7,r25bx_13,r25bx_19,r25bx_20,r25bx_25,r124a,r124d,r124c,r25c,r124e_154,r124b_154,r126a_154,r126b_154,r25b_154,r25a_154,r124ax_6,r124bx_6,r126ax_6,r124dx_6,r124ex_6,r126bx_6,r124cx_6,r25cx_6,r25ax_6,r25bx_6,q294t1_1,q294t1_2,q294t1_3,q294t1_4,q294t1_5,q294t2_1,q294t2_2,q294t2_3,q294t2_4,q294t2_5,q295t1_1,q295t1_2,q295t1_3,q295t1_4,q295t1_5,q295t1_6,q295t2_1,q295t2_2,q295t2_3,q295t2_4,q295t2_5,q295t2_6,q296t1_1,q296t1_2,q296t1_3,q296t1_4,q296t1_5,q296t2_1,q296t2_2,q296t2_3,q296t2_4,q296t2_5,q297t1_1,q297t1_2,q297t1_3,q297t1_4,q297t1_5,q297t2_1,q297t2_2,q297t2_3,q297t2_4,q297t2_5,q298t1_1,q298t1_2,q298t1_3,q298t1_4,q298t1_5,q298t1_6,q298t1_7,q298t2_1,q298t2_2,q298t2_3,q298t2_4,q298t2_5,q298t2_6,q298t2_7,q299t1_1,q299t1_2,q299t1_3,q299t1_4,q299t1_5,q299t1_6,q299t3_1,q299t3_2,q299t3_3,q299t3_4,q299t3_5,q299t3_6,r317_39,r317_105,r317_116,r317_40,r317_106,r317_42,r317_140,r317_6,r317_114,r317_7,r317_8,r317_9,r317_10,r317_118,r317_143,r317_157,r317_164,r317_166,r317_154,r318_39,r318_105,r318_116,r318_40,r318_106,r318_42,r318_140,r318_6,r318_114,r318_7,r318_8,r318_9,r318_10,r318_118,r318_143,r318_157,r318_164,r318_166,r318_154,r317x_7,r317x_13,r317x_19,r317x_20,r317x_25,r317x_6,r318x_7,r318x_13,r318x_19,r318x_20,r318x_25,,r318x_6";// dashboard variable value
            //string questions = "r317_39,r317_105,r317_116,r317_40,r317_106,r317_42,r317_140,r317_6,r317_114,r317_7,r317_8,r317_9,r317_10,r317_118,r317_143,r317_157,r317_164,r317_166,r317_154,r318_39,r318_105,r318_116,r318_40,r318_106,r318_42,r318_140,r318_6,r318_114,r318_7,r318_8,r318_9,r318_10,r318_118,r318_143,r318_157,r318_164,r318_166,r318_154,r317x_7,r317x_13,r317x_19,r317x_20,r317x_25,r317x_6,r318x_7,r318x_13,r318x_19,r318x_20,r318x_25,,r318x_6";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"C:\Users\rahul\Desktop\HH_YY_NOV2018\YY_NOV2018\YY_NOV2018.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                              //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, Country, BASE_VARIABLE_NAME, SurveyPeriod);
                            }
                        }
                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    string variable_name;
                    string u_id = null;
                    string Gender = "-- Not Available --";
                    decimal Weight = 0;
                    string AgeGroup = "-- Not Available --";
                    string Ses = "-- Not Available --";
                    string Period = "-- Not Available --";
                    string BrTom = "-- Not Available --";
                    string Location = "-- Not Available --";
                    string AdTom = "-- Not Available --";
                    string MaritalStatus= "-- Not Available --";
                    string FavouriteBrand = "-- Not Available --";
                    string Bumo = "-- Not Available --";
                    string AdSpontRomaKelapa = "-- Not Available --";
                    string AdSpontRomaMalkist = "-- Not Available --";
                    string AdSpontSlaiOLai = "-- Not Available --";
                    string AdSpontRomaMarieSusu = "-- Not Available --";
                    string AdSpontRomaMalkistAbon = "-- Not Available --";
                    string AdSpontRomaSariGandumCokelat = "-- Not Available --";
                    string AdSpontRomaKelapaSandwich = "-- Not Available --";
                    string AdSpontBiskuat = "-- Not Available --";
                    string AdSpontBetter = "-- Not Available --";
                    string AdSpontBiskuatCoklatSusu = "-- Not Available --";
                    string AdSpontBiskuatEnergi = "-- Not Available --";
                    string AdSpontBiskuatEnergiCoklat = "-- Not Available --";
                    string AdSpontBiskuatSusu = "-- Not Available --";
                    string AdSpontOreo = "-- Not Available --";
                    string AdSpontSOLTwice = "-- Not Available --";
                    string AdSpontRomamalkistcoklat = "-- Not Available --";
                    string AdSpontTwice = "-- Not Available --";
                    string AdSpontBelvita = "-- Not Available --";
                    string BrSpontRomaKelapa = "-- Not Available --";
                    string BrSpontRomaMalkist = "-- Not Available --";
                    string BrSpontSlaiOLai = "-- Not Available --";
                    string BrSpontRomaMarieSusu = "-- Not Available --";
                    string BrSpontRomaMalkistAbon = "-- Not Available --";
                    string BrSpontRomaSariGandumCokelat = "-- Not Available --";
                    string BrSpontRomaKelapaSandwich = "-- Not Available --";
                    string BrSpontBiskuat = "-- Not Available --";
                    string BrSpontBetter = "-- Not Available --";
                    string BrSpontBiskuatCoklatSusu = "-- Not Available --";
                    string BrSpontBiskuatEnergi = "-- Not Available --";
                    string BrSpontBiskuatEnergiCoklat = "-- Not Available --";
                    string BrSpontBiskuatSusu = "-- Not Available --";
                    string BrSpontOreo = "-- Not Available --";
                    string BrSpontSOLTwice = "-- Not Available --";
                    string BrSpontRomamalkistcoklat = "-- Not Available --";
                    string BrSpontTwice = "-- Not Available --";
                    string BrSpontBelvita = "-- Not Available --";
                    string BrAidRomaKelapa = "-- Not Available --";
                    string BrAidRomaMalkist = "-- Not Available --";
                    string BrAidSlaiOLai = "-- Not Available --";
                    string BrAidRomaMarieSusu = "-- Not Available --";
                    string BrAidRomaMalkistAbon = "-- Not Available --";
                    string BrAidRomaSariGandumCokelat = "-- Not Available --";
                    string BrAidRomaKelapaSandwich = "-- Not Available --";
                    string BrAidBiskuat = "-- Not Available --";
                    string BrAidBetter = "-- Not Available --";
                    string BrAidBiskuatCoklatSusu = "-- Not Available --";
                    string BrAidBiskuatEnergi = "-- Not Available --";
                    string BrAidBiskuatEnergiCoklat = "-- Not Available --";
                    string BrAidBiskuatSusu = "-- Not Available --";
                    string BrAidOreo = "-- Not Available --";
                    string BrAidSOLTwice = "-- Not Available --";
                    string BrAidRomamalkistcoklat = "-- Not Available --";
                    string BrAidTwice = "-- Not Available --";
                    string BrAidBelvita = "-- Not Available --";
                    string AdAidRomaKelapa = "-- Not Available --";
                    string AdAidRomaMalkist = "-- Not Available --";
                    string AdAidSlaiOLai = "-- Not Available --";
                    string AdAidRomaMarieSusu = "-- Not Available --";
                    string AdAidRomaMalkistAbon = "-- Not Available --";
                    string AdAidRomaSariGandumCokelat = "-- Not Available --";
                    string AdAidRomaKelapaSandwich = "-- Not Available --";
                    string AdAidBiskuat = "-- Not Available --";
                    string AdAidBetter = "-- Not Available --";
                    string AdAidBiskuatCoklatSusu = "-- Not Available --";
                    string AdAidBiskuatEnergi = "-- Not Available --";
                    string AdAidBiskuatEnergiCoklat = "-- Not Available --";
                    string AdAidBiskuatSusu = "-- Not Available --";
                    string AdAidOreo = "-- Not Available --";
                    string AdAidSOLTwice = "-- Not Available --";
                    string AdAidRomamalkistcoklat = "-- Not Available --";
                    string AdAidTwice = "-- Not Available --";
                    string AdAidBelvita = "-- Not Available --";
                    string CurConsRomaKelapa = "-- Not Available --";
                    string CurConsRomaMalkist = "-- Not Available --";
                    string CurConsSlaiOLai = "-- Not Available --";
                    string CurConsRomaMarieSusu = "-- Not Available --";
                    string CurConsRomaMalkistAbon = "-- Not Available --";
                    string CurConsRomaSariGandumCokelat = "-- Not Available --";
                    string CurConsRomaKelapaSandwich = "-- Not Available --";
                    string CurConsBiskuat = "-- Not Available --";
                    string CurConsBetter = "-- Not Available --";
                    string CurConsBiskuatCoklatSusu = "-- Not Available --";
                    string CurConsBiskuatEnergi = "-- Not Available --";
                    string CurConsBiskuatEnergiCoklat = "-- Not Available --";
                    string CurConsBiskuatSusu = "-- Not Available --";
                    string CurConsOreo = "-- Not Available --";
                    string CurConsSOLTwice = "-- Not Available --";
                    string CurConsRomamalkistcoklat = "-- Not Available --";
                    string CurConsTwice = "-- Not Available --";
                    string CurConsBelvita = "-- Not Available --";
                    string ConsLMRomaKelapa = "-- Not Available --";
                    string ConsLMRomaMalkist = "-- Not Available --";
                    string ConsLMSlaiOLai = "-- Not Available --";
                    string ConsLMRomaMarieSusu = "-- Not Available --";
                    string ConsLMRomaMalkistAbon = "-- Not Available --";
                    string ConsLMRomaSariGandumCokelat = "-- Not Available --";
                    string ConsLMRomaKelapaSandwich = "-- Not Available --";
                    string ConsLMBiskuat = "-- Not Available --";
                    string ConsLMBetter = "-- Not Available --";
                    string ConsLMBiskuatCoklatSusu = "-- Not Available --";
                    string ConsLMBiskuatEnergi = "-- Not Available --";
                    string ConsLMBiskuatEnergiCoklat = "-- Not Available --";
                    string ConsLMBiskuatSusu = "-- Not Available --";
                    string ConsLMOreo = "-- Not Available --";
                    string ConsLMSOLTwice = "-- Not Available --";
                    string ConsLMRomamalkistcoklat = "-- Not Available --";
                    string ConsLMTwice = "-- Not Available --";
                    string ConsLMBelvita = "-- Not Available --";
                    string BrTomNetKHONGGUAN = "-- Not Available --";
                    string BrTomNetROMASARIGANDUM = "-- Not Available --";
                    string BrTomNetROMACRACKERS = "-- Not Available --";
                    string BrTomNetKGCRACKERS = "-- Not Available --";
                    string BrTomNetSLAIOLAI = "-- Not Available --";
                    string BrSpontNetKHONGGUAN = "-- Not Available --";
                    string BrSpontNetROMASARIGANDUM = "-- Not Available --";
                    string BrSpontNetROMACRACKERS = "-- Not Available --";
                    string BrSpontNetKGCRACKERS = "-- Not Available --";
                    string BrSpontNetSLAIOLAI = "-- Not Available --";
                    string BrAidNetKHONGGUAN = "-- Not Available --";
                    string BrAidNetROMASARIGANDUM = "-- Not Available --";
                    string BrAidNetROMACRACKERS = "-- Not Available --";
                    string BrAidNetKGCRACKERS = "-- Not Available --";
                    string BrAidNetSLAIOLAI = "-- Not Available --";
                    string AdTomNetKHONGGUAN = "-- Not Available --";
                    string AdTomNetROMASARIGANDUM = "-- Not Available --";
                    string AdTomNetROMACRACKERS = "-- Not Available --";
                    string AdTomNetKGCRACKERS = "-- Not Available --";
                    string AdTomNetSLAIOLAI = "-- Not Available --";
                    string AdSpontNetKHONGGUAN = "-- Not Available --";
                    string AdSpontNetROMASARIGANDUM = "-- Not Available --";
                    string AdSpontNetROMACRACKERS = "-- Not Available --";
                    string AdSpontNetKGCRACKERS = "-- Not Available --";
                    string AdSpontNetSLAIOLAI = "-- Not Available --";
                    string AdAidNetKHONGGUAN = "-- Not Available --";
                    string AdAidNetROMASARIGANDUM = "-- Not Available --";
                    string AdAidNetROMACRACKERS = "-- Not Available --";
                    string AdAidNetKGCRACKERS = "-- Not Available --";
                    string AdAidNetSLAIOLAI = "-- Not Available --";
                    string NetFavBrandKhongGuan = "-- Not Available --";
                    string NetFavBrandRomaSariGandum = "-- Not Available --";
                    string NetFavBrandRomaCrackers = "-- Not Available --";
                    string NetFavBrandKGCrakers = "-- Not Available --";
                    string NetFavBrandSlaiOlai = "-- Not Available --";
                    string NetBumoKhongGuan = "-- Not Available --";
                    string NetBumoRomaSariGandum = "-- Not Available --";
                    string NetBumoRomaCrackers = "-- Not Available --";
                    string NetBumoKGCrakers = "-- Not Available --";
                    string NetBumoSlaiOlai = "-- Not Available --";
                    string NetConsuLMKhongGuan = "-- Not Available --";
                    string NetConsuLMRomaSariGandum = "-- Not Available --";
                    string NetConsuLMRomaCrackers = "-- Not Available --";
                    string NetConsuLMKGCrakers = "-- Not Available --";
                    string NetConsuLMSlaiOlai = "-- Not Available --";
                    string NetConCurKhongGuan = "-- Not Available --";
                    string NetConCurRomaSariGandum = "-- Not Available --";
                    string NetConCurRomaCrackers = "-- Not Available --";
                    string NetConCurKGCrakers = "-- Not Available --";
                    string NetConCurSlaiOlai = "-- Not Available --";
                    string BrTomBK = "-- Not Available --";
                    string AdTomBK = "-- Not Available --";
                    string FavouriteBrandBk = "-- Not Available --";
                    string BumoBK = "-- Not Available --";
                    string AdSpontBisvitSelimut = "-- Not Available --";
                    string BrSpontBisvitSelimut = "-- Not Available --";
                    string BrAidBisvitSelimut = "-- Not Available --";
                    string AdAidBisvitSelimut = "-- Not Available --";
                    string CurConsBisvitSelimut = "-- Not Available --";
                    string ConsLMBisvitSelimut = "-- Not Available --";
                    string BrTomNetHATARI = "-- Not Available --";
                    string BrSpontNetHATARI = "-- Not Available --";
                    string BrAidNetHATARI = "-- Not Available --";
                    string AdTomNetHATARI = "-- Not Available --";
                    string AdSpontNetHATARI = "-- Not Available --";
                    string AdAidNetHATARI = "-- Not Available --";
                    string NetFavBrandHATARI = "-- Not Available --";
                    string NetBumoHATARI = "-- Not Available --";
                    string NetConsuLMHATARI = "-- Not Available --";
                    string NetConCurHATARI = "-- Not Available --"; 
	                string q294t1_1 = "-- Not Available --";
                    string q294t1_2 = "-- Not Available --";
                    string q294t1_3 = "-- Not Available --";
                    string q294t1_4 = "-- Not Available --";
                    string q294t1_5 = "-- Not Available --";
                    string q294t2_1 = "-- Not Available --";
                    string q294t2_2 = "-- Not Available --";
                    string q294t2_3 = "-- Not Available --";
                    string q294t2_4 = "-- Not Available --";
                    string q294t2_5 = "-- Not Available --";
                    string q295t1_1 = "-- Not Available --";
                    string q295t1_2 = "-- Not Available --";
                    string q295t1_3 = "-- Not Available --";
                    string q295t1_4 = "-- Not Available --";
                    string q295t1_5 = "-- Not Available --";
                    string q295t1_6 = "-- Not Available --";
                    string q295t2_1 = "-- Not Available --";
                    string q295t2_2 = "-- Not Available --";
                    string q295t2_3 = "-- Not Available --";
                    string q295t2_4 = "-- Not Available --";
                    string q295t2_5 = "-- Not Available --";
                    string q295t2_6 = "-- Not Available --";
                    string q296t1_1 = "-- Not Available --";
                    string q296t1_2 = "-- Not Available --";
                    string q296t1_3 = "-- Not Available --";
                    string q296t1_4 = "-- Not Available --";
                    string q296t1_5 = "-- Not Available --";
                    string q296t2_1 = "-- Not Available --";
                    string q296t2_2 = "-- Not Available --";
                    string q296t2_3 = "-- Not Available --";
                    string q296t2_4 = "-- Not Available --";
                    string q296t2_5 = "-- Not Available --";
                    string q297t1_1 = "-- Not Available --";
                    string q297t1_2 = "-- Not Available --";
                    string q297t1_3 = "-- Not Available --";
                    string q297t1_4 = "-- Not Available --";
                    string q297t1_5 = "-- Not Available --";
                    string q297t2_1 = "-- Not Available --";
                    string q297t2_2 = "-- Not Available --";
                    string q297t2_3 = "-- Not Available --";
                    string q297t2_4 = "-- Not Available --";
                    string q297t2_5 = "-- Not Available --";
                    string q298t1_1 = "-- Not Available --";
                    string q298t1_2 = "-- Not Available --";
                    string q298t1_3 = "-- Not Available --";
                    string q298t1_4 = "-- Not Available --";
                    string q298t1_5 = "-- Not Available --";
                    string q298t1_6 = "-- Not Available --";
                    string q298t1_7 = "-- Not Available --";
                    string q298t2_1 = "-- Not Available --";
                    string q298t2_2 = "-- Not Available --";
                    string q298t2_3 = "-- Not Available --";
                    string q298t2_4 = "-- Not Available --";
                    string q298t2_5 = "-- Not Available --";
                    string q298t2_6 = "-- Not Available --";
                    string q298t2_7 = "-- Not Available --";
                    string q299t1_1 = "-- Not Available --";
                    string q299t1_2 = "-- Not Available --";
                    string q299t1_3 = "-- Not Available --";
                    string q299t1_4 = "-- Not Available --";
                    string q299t1_5 = "-- Not Available --";
                    string q299t1_6 = "-- Not Available --";
                    string q299t3_1 = "-- Not Available --";
                    string q299t3_2 = "-- Not Available --";
                    string q299t3_3 = "-- Not Available --";
                    string q299t3_4 = "-- Not Available --";
                    string q299t3_5 = "-- Not Available --";
                    string q299t3_6 = "-- Not Available --";
                    string ConsP1WRomaKelapa = "-- Not Available --";
                    string ConsP1WRomaMalkist = "-- Not Available --";
                    string ConsP1WSlaiOLai = "-- Not Available --";
                    string ConsP1WRomaMarieSusu = "-- Not Available --";
                    string ConsP1WRomaMalkistAbon = "-- Not Available --";
                    string ConsP1WRomaSariGandumCokelat = "-- Not Available --";
                    string ConsP1WRomaKelapaSandwich = "-- Not Available --";
                    string ConsP1WBiskuat = "-- Not Available --";
                    string ConsP1WBetter = "-- Not Available --";
                    string ConsP1WBiskuatCoklatSusu = "-- Not Available --";
                    string ConsP1WBiskuatEnergi = "-- Not Available --";
                    string ConsP1WBiskuatEnergiCoklat = "-- Not Available --";
                    string ConsP1WBiskuatSusu = "-- Not Available --";
                    string ConsP1WOreo = "-- Not Available --";
                    string ConsP1WSOLTwice = "-- Not Available --";
                    string ConsP1WRomamalkistcoklat = "-- Not Available --";
                    string ConsP1WTwice = "-- Not Available --";
                    string ConsP1WBelvita = "-- Not Available --";
                    string ConsP1WBisvitSelimut = "-- Not Available --";
                    string ConsP1DRomaKelapa = "-- Not Available --";
                    string ConsP1DRomaMalkist = "-- Not Available --";
                    string ConsP1DSlaiOLai = "-- Not Available --";
                    string ConsP1DRomaMarieSusu = "-- Not Available --";
                    string ConsP1DRomaMalkistAbon = "-- Not Available --";
                    string ConsP1DRomaSariGandumCokelat = "-- Not Available --";
                    string ConsP1DRomaKelapaSandwich = "-- Not Available --";
                    string ConsP1DBiskuat = "-- Not Available --";
                    string ConsP1DBetter = "-- Not Available --";
                    string ConsP1DBiskuatCoklatSusu = "-- Not Available --";
                    string ConsP1DBiskuatEnergi = "-- Not Available --";
                    string ConsP1DBiskuatEnergiCoklat = "-- Not Available --";
                    string ConsP1DBiskuatSusu = "-- Not Available --";
                    string ConsP1DOreo = "-- Not Available --";
                    string ConsP1DSOLTwice = "-- Not Available --";
                    string ConsP1DRomamalkistcoklat = "-- Not Available --";
                    string ConsP1DTwice = "-- Not Available --";
                    string ConsP1DBelvita = "-- Not Available --";
                    string ConsP1DBisvitSelimut = "-- Not Available --";
                    string NetConsuP1WKhongGuan = "-- Not Available --";
                    string NetConsuP1WRomaSariGandum = "-- Not Available --";
                    string NetConsuP1WRomaCrackers = "-- Not Available --";
                    string NetConsuP1WKGCrakers = "-- Not Available --";
                    string NetConsuP1WSlaiOlai = "-- Not Available --";
                    string NetConsuP1WHATARI = "-- Not Available --";
                    string NetConsuP1DKhongGuan = "-- Not Available --";
                    string NetConsuP1DRomaSariGandum = "-- Not Available --";
                    string NetConsuP1DRomaCrackers = "-- Not Available --";
                    string NetConsuP1DKGCrakers = "-- Not Available --";
                    string NetConsuP1DSlaiOlai = "-- Not Available --";
                    string NetConsuP1DHATARI = "-- Not Available --";

                   

                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;
                                switch (variable_name)
                                {
                                    case "iobs":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, SurveyPeriod, u_id);
                                            //userID = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "weight":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "r8":
                                        {
                                            Gender = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124a":
                                        {
                                            BrTom = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124d":
                                        {
                                            AdTom = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124c":
                                        {
                                            FavouriteBrand = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25c":
                                        {
                                            Bumo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r1":
                                        {
                                            Location = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r7":
                                        {
                                            AgeGroup = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r12":
                                        {
                                            Ses = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r2":
                                        {
                                            Period = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_39":
                                        {
                                            AdSpontRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_105":
                                        {
                                            AdSpontRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_116":
                                        {
                                            AdSpontSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_40":
                                        {
                                            AdSpontRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_106":
                                        {
                                            AdSpontRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_42":
                                        {
                                            AdSpontRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_140":
                                        {
                                            AdSpontRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_6":
                                        {
                                            AdSpontBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_114":
                                        {
                                            AdSpontBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_7":
                                        {
                                            AdSpontBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_8":
                                        {
                                            AdSpontBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_9":
                                        {
                                            AdSpontBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_10":
                                        {
                                            AdSpontBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_118":
                                        {
                                            AdSpontOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_143":
                                        {
                                            AdSpontSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_157":
                                        {
                                            AdSpontRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_164":
                                        {
                                            AdSpontTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124e_166":
                                        {
                                            AdSpontBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_39":
                                        {
                                            BrSpontRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_105":
                                        {
                                            BrSpontRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_116":
                                        {
                                            BrSpontSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_40":
                                        {
                                            BrSpontRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_106":
                                        {
                                            BrSpontRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_42":
                                        {
                                            BrSpontRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_140":
                                        {
                                            BrSpontRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_6":
                                        {
                                            BrSpontBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_114":
                                        {
                                            BrSpontBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_7":
                                        {
                                            BrSpontBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_8":
                                        {
                                            BrSpontBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_9":
                                        {
                                            BrSpontBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_10":
                                        {
                                            BrSpontBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_118":
                                        {
                                            BrSpontOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_143":
                                        {
                                            BrSpontSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_157":
                                        {
                                            BrSpontRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_164":
                                        {
                                            BrSpontTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_166":
                                        {
                                            BrSpontBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_39":
                                        {
                                            BrAidRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_105":
                                        {
                                            BrAidRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_116":
                                        {
                                            BrAidSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_40":
                                        {
                                            BrAidRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_106":
                                        {
                                            BrAidRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_42":
                                        {
                                            BrAidRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_140":
                                        {
                                            BrAidRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_6":
                                        {
                                            BrAidBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_114":
                                        {
                                            BrAidBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_7":
                                        {
                                            BrAidBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_8":
                                        {
                                            BrAidBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_9":
                                        {
                                            BrAidBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_10":
                                        {
                                            BrAidBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_118":
                                        {
                                            BrAidOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_143":
                                        {
                                            BrAidSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_157":
                                        {
                                            BrAidRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_164":
                                        {
                                            BrAidTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_166":
                                        {
                                            BrAidBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_39":
                                        {
                                            AdAidRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_105":
                                        {
                                            AdAidRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_116":
                                        {
                                            AdAidSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_40":
                                        {
                                            AdAidRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_106":
                                        {
                                            AdAidRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_42":
                                        {
                                            AdAidRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_140":
                                        {
                                            AdAidRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_6":
                                        {
                                            AdAidBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_114":
                                        {
                                            AdAidBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_7":
                                        {
                                            AdAidBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_8":
                                        {
                                            AdAidBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_9":
                                        {
                                            AdAidBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_10":
                                        {
                                            AdAidBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_118":
                                        {
                                            AdAidOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_143":
                                        {
                                            AdAidSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_157":
                                        {
                                            AdAidRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_164":
                                        {
                                            AdAidTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_166":
                                        {
                                            AdAidBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_39":
                                        {
                                            CurConsRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_105":
                                        {
                                            CurConsRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_116":
                                        {
                                            CurConsSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_40":
                                        {
                                            CurConsRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_106":
                                        {
                                            CurConsRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_42":
                                        {
                                            CurConsRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_140":
                                        {
                                            CurConsRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_6":
                                        {
                                            CurConsBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_114":
                                        {
                                            CurConsBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_7":
                                        {
                                            CurConsBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_8":
                                        {
                                            CurConsBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_9":
                                        {
                                            CurConsBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_10":
                                        {
                                            CurConsBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_118":
                                        {
                                            CurConsOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_143":
                                        {
                                            CurConsSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_157":
                                        {
                                            CurConsRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_164":
                                        {
                                            CurConsTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_166":
                                        {
                                            CurConsBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_39":
                                        {
                                            ConsLMRomaKelapa = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_105":
                                        {
                                            ConsLMRomaMalkist = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_116":
                                        {
                                            ConsLMSlaiOLai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_40":
                                        {
                                            ConsLMRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_106":
                                        {
                                            ConsLMRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_42":
                                        {
                                            ConsLMRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_140":
                                        {
                                            ConsLMRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_6":
                                        {
                                            ConsLMBiskuat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_114":
                                        {
                                            ConsLMBetter = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_7":
                                        {
                                            ConsLMBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_8":
                                        {
                                            ConsLMBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_9":
                                        {
                                            ConsLMBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_10":
                                        {
                                            ConsLMBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_118":
                                        {
                                            ConsLMOreo = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_143":
                                        {
                                            ConsLMSOLTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_157":
                                        {
                                            ConsLMRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_164":
                                        {
                                            ConsLMTwice = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_166":
                                        {
                                            ConsLMBelvita = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_7":
                                        {
                                            BrTomNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_13":
                                        {
                                            BrTomNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_19":
                                        {
                                            BrTomNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_20":
                                        {
                                            BrTomNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_25":
                                        {
                                            BrTomNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_7":
                                        {
                                            BrSpontNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_13":
                                        {
                                            BrSpontNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_19":
                                        {
                                            BrSpontNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_20":
                                        {
                                            BrSpontNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_25":
                                        {
                                            BrSpontNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_7":
                                        {
                                            BrAidNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_13":
                                        {
                                            BrAidNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_19":
                                        {
                                            BrAidNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_20":
                                        {
                                            BrAidNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_25":
                                        {
                                            BrAidNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_7":
                                        {
                                            AdTomNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_13":
                                        {
                                            AdTomNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_19":
                                        {
                                            AdTomNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_20":
                                        {
                                            AdTomNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_25":
                                        {
                                            AdTomNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_7":
                                        {
                                            AdSpontNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_13":
                                        {
                                            AdSpontNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_19":
                                        {
                                            AdSpontNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_20":
                                        {
                                            AdSpontNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_25":
                                        {
                                            AdSpontNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_7":
                                        {
                                            AdAidNetKHONGGUAN = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_13":
                                        {
                                            AdAidNetROMASARIGANDUM = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_19":
                                        {
                                            AdAidNetROMACRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_20":
                                        {
                                            AdAidNetKGCRACKERS = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_25":
                                        {
                                            AdAidNetSLAIOLAI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_7":
                                        {
                                            NetFavBrandKhongGuan = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_13":
                                        {
                                            NetFavBrandRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_19":
                                        {
                                            NetFavBrandRomaCrackers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_20":
                                        {
                                            NetFavBrandKGCrakers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_25":
                                        {
                                            NetFavBrandSlaiOlai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_7":
                                        {
                                            NetBumoKhongGuan = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_13":
                                        {
                                            NetBumoRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_19":
                                        {
                                            NetBumoRomaCrackers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_20":
                                        {
                                            NetBumoKGCrakers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_25":
                                        {
                                            NetBumoSlaiOlai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_7":
                                        {
                                            NetConsuLMKhongGuan = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_13":
                                        {
                                            NetConsuLMRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_19":
                                        {
                                            NetConsuLMRomaCrackers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_20":
                                        {
                                            NetConsuLMKGCrakers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_25":
                                        {
                                            NetConsuLMSlaiOlai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_7":
                                        {
                                            NetConCurKhongGuan = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_13":
                                        {
                                            NetConCurRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_19":
                                        {
                                            NetConCurRomaCrackers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_20":
                                        {
                                            NetConCurKGCrakers = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_25":
                                        {
                                            NetConCurSlaiOlai = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    
                                    case "r124e_154":
                                        {
                                            AdSpontBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124b_154":
                                        {
                                            BrSpontBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126a_154":
                                        {
                                            BrAidBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126b_154":
                                        {
                                            AdAidBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25b_154":
                                        {
                                            CurConsBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25a_154":
                                        {
                                            ConsLMBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ax_6":
                                        {
                                            BrTomNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124bx_6":
                                        {
                                            BrSpontNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126ax_6":
                                        {
                                            BrAidNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124dx_6":
                                        {
                                            AdTomNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124ex_6":
                                        {
                                            AdSpontNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r126bx_6":
                                        {
                                            AdAidNetHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r124cx_6":
                                        {
                                            NetFavBrandHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25cx_6":
                                        {
                                            NetBumoHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25ax_6":
                                        {
                                            NetConsuLMHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "r25bx_6":
                                        {
                                            NetConCurHATARI = Convert.ToString(record.GetValue(variable));
                                            break;
                                        }
                                    case "q294t1_1":   
                                       {  
                                          q294t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t1_2":   
                                       {  
                                          q294t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t1_3":   
                                       {  
                                          q294t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t1_4":   
                                       {  
                                          q294t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t1_5":   
                                       {  
                                          q294t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t2_1":   
                                       {  
                                          q294t2_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t2_2":   
                                       {  
                                          q294t2_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t2_3":   
                                       {  
                                          q294t2_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t2_4":   
                                       {  
                                          q294t2_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q294t2_5":   
                                       {  
                                          q294t2_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_1":   
                                       {  
                                          q295t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_2":   
                                       {  
                                          q295t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_3":   
                                       {  
                                          q295t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_4":   
                                       {  
                                          q295t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_5":   
                                       {  
                                          q295t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t1_6":   
                                       {  
                                          q295t1_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_1":   
                                       {  
                                          q295t2_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_2":   
                                       {  
                                          q295t2_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_3":   
                                       {  
                                          q295t2_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_4":   
                                       {  
                                          q295t2_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_5":   
                                       {  
                                          q295t2_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q295t2_6":   
                                       {  
                                          q295t2_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t1_1":   
                                       {  
                                          q296t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t1_2":   
                                       {  
                                          q296t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t1_3":   
                                       {  
                                          q296t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t1_4":   
                                       {  
                                          q296t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t1_5":   
                                       {  
                                          q296t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t2_1":   
                                       {  
                                          q296t2_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t2_2":   
                                       {  
                                          q296t2_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t2_3":   
                                       {  
                                          q296t2_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t2_4":   
                                       {  
                                          q296t2_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q296t2_5":   
                                       {  
                                          q296t2_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t1_1":   
                                       {  
                                          q297t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t1_2":   
                                       {  
                                          q297t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t1_3":   
                                       {  
                                          q297t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t1_4":   
                                       {  
                                          q297t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t1_5":   
                                       {  
                                          q297t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t2_1":   
                                       {  
                                          q297t2_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t2_2":   
                                       {  
                                          q297t2_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t2_3":   
                                       {  
                                          q297t2_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t2_4":   
                                       {  
                                          q297t2_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q297t2_5":   
                                       {  
                                          q297t2_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_1":   
                                       {  
                                          q298t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_2":   
                                       {  
                                          q298t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_3":   
                                       {  
                                          q298t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_4":   
                                       {  
                                          q298t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_5":   
                                       {  
                                          q298t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_6":   
                                       {  
                                          q298t1_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t1_7":   
                                       {  
                                          q298t1_7 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_1":   
                                       {  
                                          q298t2_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_2":   
                                       {  
                                          q298t2_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_3":   
                                       {  
                                          q298t2_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_4":   
                                       {  
                                          q298t2_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_5":   
                                       {  
                                          q298t2_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_6":   
                                       {  
                                          q298t2_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q298t2_7":   
                                       {  
                                          q298t2_7 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_1":   
                                       {  
                                          q299t1_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_2":   
                                       {  
                                          q299t1_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_3":   
                                       {  
                                          q299t1_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_4":   
                                       {  
                                          q299t1_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_5":   
                                       {  
                                          q299t1_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t1_6":   
                                       {  
                                          q299t1_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_1":   
                                       {  
                                          q299t3_1 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_2":   
                                       {  
                                          q299t3_2 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_3":   
                                       {  
                                          q299t3_3 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_4":   
                                       {  
                                          q299t3_4 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_5":   
                                       {  
                                          q299t3_5 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }
                                    case "q299t3_6":   
                                       {  
                                          q299t3_6 = Convert.ToString(record.GetValue(variable));    
                                          break;    
                                       }

                                    case "r317_39":
                                       {
                                           ConsP1WRomaKelapa = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_105":
                                       {
                                           ConsP1WRomaMalkist = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_116":
                                       {
                                           ConsP1WSlaiOLai = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_40":
                                       {
                                           ConsP1WRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_106":
                                       {
                                           ConsP1WRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_42":
                                       {
                                           ConsP1WRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_140":
                                       {
                                           ConsP1WRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_6":
                                       {
                                           ConsP1WBiskuat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_114":
                                       {
                                           ConsP1WBetter = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_7":
                                       {
                                           ConsP1WBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_8":
                                       {
                                           ConsP1WBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_9":
                                       {
                                           ConsP1WBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_10":
                                       {
                                           ConsP1WBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_118":
                                       {
                                           ConsP1WOreo = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_143":
                                       {
                                           ConsP1WSOLTwice = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_157":
                                       {
                                           ConsP1WRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_164":
                                       {
                                           ConsP1WTwice = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_166":
                                       {
                                           ConsP1WBelvita = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317_154":
                                       {
                                           ConsP1WBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }

                                    case "r318_39":
                                       {
                                           ConsP1DRomaKelapa = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_105":
                                       {
                                           ConsP1DRomaMalkist = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_116":
                                       {
                                           ConsP1DSlaiOLai = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_40":
                                       {
                                           ConsP1DRomaMarieSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_106":
                                       {
                                           ConsP1DRomaMalkistAbon = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_42":
                                       {
                                           ConsP1DRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_140":
                                       {
                                           ConsP1DRomaKelapaSandwich = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_6":
                                       {
                                           ConsP1DBiskuat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_114":
                                       {
                                           ConsP1DBetter = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_7":
                                       {
                                           ConsP1DBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_8":
                                       {
                                           ConsP1DBiskuatEnergi = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_9":
                                       {
                                           ConsP1DBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_10":
                                       {
                                           ConsP1DBiskuatSusu = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_118":
                                       {
                                           ConsP1DOreo = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_143":
                                       {
                                           ConsP1DSOLTwice = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_157":
                                       {
                                           ConsP1DRomamalkistcoklat = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_164":
                                       {
                                           ConsP1DTwice = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_166":
                                       {
                                           ConsP1DBelvita = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318_154":
                                       {
                                           ConsP1DBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_7":
                                       {
                                           NetConsuP1WKhongGuan = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_13":
                                       {
                                           NetConsuP1WRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_19":
                                       {
                                           NetConsuP1WRomaCrackers = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_20":
                                       {
                                           NetConsuP1WKGCrakers = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_25":
                                       {
                                           NetConsuP1WSlaiOlai = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r317x_6":
                                       {
                                           NetConsuP1WHATARI = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_7":
                                       {
                                           NetConsuP1DKhongGuan = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_13":
                                       {
                                           NetConsuP1DRomaSariGandum = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_19":
                                       {
                                           NetConsuP1DRomaCrackers = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_20":
                                       {
                                           NetConsuP1DKGCrakers = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_25":
                                       {
                                           NetConsuP1DSlaiOlai = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
                                    case "r318x_6":
                                       {
                                           NetConsuP1DHATARI = Convert.ToString(record.GetValue(variable));
                                           break;
                                       }
									   
										
                                    

                                  }

                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_Dashboard_values(userID, Gender, Country, Location, MaritalStatus, SurveyID, SurveyPeriod, Weight, AgeGroup, Ses, Period, BrTom, AdTom, Bumo, FavouriteBrand, AdSpontRomaKelapa, AdSpontRomaMalkist, AdSpontSlaiOLai, AdSpontRomaMarieSusu, AdSpontRomaMalkistAbon, AdSpontRomaSariGandumCokelat, AdSpontRomaKelapaSandwich, AdSpontBiskuat, AdSpontBetter, AdSpontBiskuatCoklatSusu, AdSpontBiskuatEnergi, AdSpontBiskuatEnergiCoklat, AdSpontBiskuatSusu, AdSpontOreo, AdSpontSOLTwice, AdSpontRomamalkistcoklat, AdSpontTwice, AdSpontBelvita, BrSpontRomaKelapa, BrSpontRomaMalkist, BrSpontSlaiOLai, BrSpontRomaMarieSusu, BrSpontRomaMalkistAbon, BrSpontRomaSariGandumCokelat, BrSpontRomaKelapaSandwich, BrSpontBiskuat, BrSpontBetter, BrSpontBiskuatCoklatSusu, BrSpontBiskuatEnergi, BrSpontBiskuatEnergiCoklat, BrSpontBiskuatSusu, BrSpontOreo, BrSpontSOLTwice, BrSpontRomamalkistcoklat, BrSpontTwice, BrSpontBelvita, BrAidRomaKelapa, BrAidRomaMalkist, BrAidSlaiOLai, BrAidRomaMarieSusu, BrAidRomaMalkistAbon, BrAidRomaSariGandumCokelat, BrAidRomaKelapaSandwich, BrAidBiskuat, BrAidBetter, BrAidBiskuatCoklatSusu, BrAidBiskuatEnergi, BrAidBiskuatEnergiCoklat, BrAidBiskuatSusu, BrAidOreo, BrAidSOLTwice, BrAidRomamalkistcoklat, BrAidTwice, BrAidBelvita, AdAidRomaKelapa, AdAidRomaMalkist, AdAidSlaiOLai, AdAidRomaMarieSusu, AdAidRomaMalkistAbon, AdAidRomaSariGandumCokelat, AdAidRomaKelapaSandwich, AdAidBiskuat, AdAidBetter, AdAidBiskuatCoklatSusu, AdAidBiskuatEnergi, AdAidBiskuatEnergiCoklat, AdAidBiskuatSusu, AdAidOreo, AdAidSOLTwice, AdAidRomamalkistcoklat, AdAidTwice, AdAidBelvita, CurConsRomaKelapa, CurConsRomaMalkist, CurConsSlaiOLai, CurConsRomaMarieSusu, CurConsRomaMalkistAbon, CurConsRomaSariGandumCokelat, CurConsRomaKelapaSandwich, CurConsBiskuat, CurConsBetter, CurConsBiskuatCoklatSusu, CurConsBiskuatEnergi, CurConsBiskuatEnergiCoklat, CurConsBiskuatSusu, CurConsOreo, CurConsSOLTwice, CurConsRomamalkistcoklat, CurConsTwice, CurConsBelvita, ConsLMRomaKelapa, ConsLMRomaMalkist, ConsLMSlaiOLai, ConsLMRomaMarieSusu, ConsLMRomaMalkistAbon, ConsLMRomaSariGandumCokelat, ConsLMRomaKelapaSandwich, ConsLMBiskuat, ConsLMBetter, ConsLMBiskuatCoklatSusu, ConsLMBiskuatEnergi, ConsLMBiskuatEnergiCoklat, ConsLMBiskuatSusu, ConsLMOreo, ConsLMSOLTwice, ConsLMRomamalkistcoklat, ConsLMTwice, ConsLMBelvita, BrTomNetKHONGGUAN, BrTomNetROMASARIGANDUM, BrTomNetROMACRACKERS, BrTomNetKGCRACKERS, BrTomNetSLAIOLAI, BrSpontNetKHONGGUAN, BrSpontNetROMASARIGANDUM, BrSpontNetROMACRACKERS, BrSpontNetKGCRACKERS, BrSpontNetSLAIOLAI, BrAidNetKHONGGUAN, BrAidNetROMASARIGANDUM, BrAidNetROMACRACKERS, BrAidNetKGCRACKERS, BrAidNetSLAIOLAI, AdTomNetKHONGGUAN, AdTomNetROMASARIGANDUM, AdTomNetROMACRACKERS, AdTomNetKGCRACKERS, AdTomNetSLAIOLAI, AdSpontNetKHONGGUAN, AdSpontNetROMASARIGANDUM, AdSpontNetROMACRACKERS, AdSpontNetKGCRACKERS, AdSpontNetSLAIOLAI, AdAidNetKHONGGUAN, AdAidNetROMASARIGANDUM, AdAidNetROMACRACKERS, AdAidNetKGCRACKERS, AdAidNetSLAIOLAI, NetFavBrandKhongGuan, NetFavBrandRomaSariGandum, NetFavBrandRomaCrackers, NetFavBrandKGCrakers, NetFavBrandSlaiOlai, NetBumoKhongGuan, NetBumoRomaSariGandum, NetBumoRomaCrackers, NetBumoKGCrakers, NetBumoSlaiOlai, NetConsuLMKhongGuan, NetConsuLMRomaSariGandum, NetConsuLMRomaCrackers, NetConsuLMKGCrakers, NetConsuLMSlaiOlai, NetConCurKhongGuan, NetConCurRomaSariGandum, NetConCurRomaCrackers, NetConCurKGCrakers, NetConCurSlaiOlai, AdSpontBisvitSelimut, BrSpontBisvitSelimut, BrAidBisvitSelimut, AdAidBisvitSelimut, CurConsBisvitSelimut, ConsLMBisvitSelimut, BrTomNetHATARI, BrSpontNetHATARI, BrAidNetHATARI, AdTomNetHATARI, AdSpontNetHATARI, AdAidNetHATARI, NetFavBrandHATARI, NetBumoHATARI, NetConsuLMHATARI, NetConCurHATARI, q294t1_1, q294t1_2, q294t1_3, q294t1_4, q294t1_5, q294t2_1, q294t2_2, q294t2_3, q294t2_4, q294t2_5, q295t1_1, q295t1_2, q295t1_3, q295t1_4, q295t1_5, q295t1_6, q295t2_1, q295t2_2, q295t2_3, q295t2_4, q295t2_5, q295t2_6, q296t1_1, q296t1_2, q296t1_3, q296t1_4, q296t1_5, q296t2_1, q296t2_2, q296t2_3, q296t2_4, q296t2_5, q297t1_1, q297t1_2, q297t1_3, q297t1_4, q297t1_5, q297t2_1, q297t2_2, q297t2_3, q297t2_4, q297t2_5, q298t1_1, q298t1_2, q298t1_3, q298t1_4, q298t1_5, q298t1_6, q298t1_7, q298t2_1, q298t2_2, q298t2_3, q298t2_4, q298t2_5, q298t2_6, q298t2_7, q299t1_1, q299t1_2, q299t1_3, q299t1_4, q299t1_5, q299t1_6, q299t3_1, q299t3_2, q299t3_3, q299t3_4, q299t3_5, q299t3_6, ConsP1WRomaKelapa, ConsP1WRomaMalkist, ConsP1WSlaiOLai, ConsP1WRomaMarieSusu, ConsP1WRomaMalkistAbon, ConsP1WRomaSariGandumCokelat, ConsP1WRomaKelapaSandwich, ConsP1WBiskuat, ConsP1WBetter, ConsP1WBiskuatCoklatSusu, ConsP1WBiskuatEnergi, ConsP1WBiskuatEnergiCoklat, ConsP1WBiskuatSusu, ConsP1WOreo, ConsP1WSOLTwice, ConsP1WRomamalkistcoklat, ConsP1WTwice, ConsP1WBelvita, ConsP1WBisvitSelimut, ConsP1DRomaKelapa, ConsP1DRomaMalkist, ConsP1DSlaiOLai, ConsP1DRomaMarieSusu, ConsP1DRomaMalkistAbon, ConsP1DRomaSariGandumCokelat, ConsP1DRomaKelapaSandwich, ConsP1DBiskuat, ConsP1DBetter, ConsP1DBiskuatCoklatSusu, ConsP1DBiskuatEnergi, ConsP1DBiskuatEnergiCoklat, ConsP1DBiskuatSusu, ConsP1DOreo, ConsP1DSOLTwice, ConsP1DRomamalkistcoklat, ConsP1DTwice, ConsP1DBelvita, ConsP1DBisvitSelimut, NetConsuP1WKhongGuan, NetConsuP1WRomaSariGandum, NetConsuP1WRomaCrackers, NetConsuP1WKGCrakers, NetConsuP1WSlaiOlai, NetConsuP1WHATARI, NetConsuP1DKhongGuan, NetConsuP1DRomaSariGandum, NetConsuP1DRomaCrackers, NetConsuP1DKGCrakers, NetConsuP1DSlaiOlai, NetConsuP1DHATARI);
                        //iobj.insert_Dashboard_NewBrand(userID, SurveyID, SurveyPeriod, AdSpontBisvitSelimut, BrSpontBisvitSelimut, BrAidBisvitSelimut, AdAidBisvitSelimut, CurConsBisvitSelimut, ConsLMBisvitSelimut, BrTomNetHATARI, BrSpontNetHATARI, BrAidNetHATARI, AdTomNetHATARI, AdSpontNetHATARI, AdAidNetHATARI, NetFavBrandHATARI, NetBumoHATARI, NetConsuLMHATARI, NetConCurHATARI);
                        //iobj.insert_Dashboard_values_bus_bi(userID, SurveyID, SurveyPeriod, Period, q142ft2_1, q142ft2_2, q142ft2_3, q142ft2_4, q142ft2_5, q142ft2_8, q142ft2_12, q142ft2_13, q142ft2_14, q142ft2_18, q294t1_1, q294t1_2, q294t1_3, q294t1_4, q294t1_5, q294t2_1, q294t2_2, q294t2_3, q294t2_4, q294t2_5, q295t1_1, q295t1_2, q295t1_3, q295t1_4, q295t1_5, q295t1_6, q295t2_1, q295t2_2, q295t2_3, q295t2_4, q295t2_5, q295t2_6, q296t1_1, q296t1_2, q296t1_3, q296t1_4, q296t1_5, q296t2_1, q296t2_2, q296t2_3, q296t2_4, q296t2_5, q297t1_1, q297t1_2, q297t1_3, q297t1_4, q297t1_5, q297t2_1, q297t2_2, q297t2_3, q297t2_4, q297t2_5, q298t1_1, q298t1_2, q298t1_3, q298t1_4, q298t1_5, q298t1_6, q298t1_7, q298t2_1, q298t2_2, q298t2_3, q298t2_4, q298t2_5, q298t2_6, q298t2_7, q299t1_1, q299t1_2, q299t1_3, q299t1_4, q299t1_5, q299t1_6, q299t3_1, q299t3_2, q299t3_3, q299t3_4, q299t3_5, q299t3_6);
                    }

                }
             }
        }

        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
    class Biscuit_insertion
    {
        SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
        internal void insert_Dashboard_variable_values(string VARIABLE_NAME, string VARIABLE_NAME_SUB_NAME, string VARIABLE_ID, string VARIABLE_VALUE, string VARIABLE_NAME_QUESTION, int SurveyID, string Country, string BASE_VARIABLE_NAME, string SurveyPeriod)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardSPS_Variable_Values (VARIABLE_NAME,VARIABLE_NAME_SUB_NAME,VARIABLE_ID,VARIABLE_VALUE,VARIABLE_NAME_QUESTION,SURVEY_ID,SURVEY_COUNTRY,BASE_VARIABLE_NAME,SURVEY_PERIOD) " + "VALUES('" + VARIABLE_NAME + "','" + VARIABLE_NAME_SUB_NAME + "','" + VARIABLE_ID + "','" + VARIABLE_VALUE + "','" + VARIABLE_NAME_QUESTION + "','" + SurveyID + "','" + Country + "','" + BASE_VARIABLE_NAME + "','" + SurveyPeriod + "')", connection);
            try
            {

                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Dashboard variable values inserted successfully");

                connection.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
                Console.ReadLine();
            }
        }

        internal void insert_Dashboard_values(string userID, string Gender, string Country, string Location, string MaritalStatus, int SurveyID, string SurveyPeriod, decimal Weight, string AgeGroup, string Ses, string Period, string BrTom, string AdTom, string Bumo, string FavouriteBrand, string AdSpontRomaKelapa, string AdSpontRomaMalkist, string AdSpontSlaiOLai, string AdSpontRomaMarieSusu, string AdSpontRomaMalkistAbon, string AdSpontRomaSariGandumCokelat, string AdSpontRomaKelapaSandwich, string AdSpontBiskuat, string AdSpontBetter, string AdSpontBiskuatCoklatSusu, string AdSpontBiskuatEnergi, string AdSpontBiskuatEnergiCoklat, string AdSpontBiskuatSusu, string AdSpontOreo, string AdSpontSOLTwice, string AdSpontRomamalkistcoklat, string AdSpontTwice, string AdSpontBelvita, string BrSpontRomaKelapa, string BrSpontRomaMalkist, string BrSpontSlaiOLai, string BrSpontRomaMarieSusu, string BrSpontRomaMalkistAbon, string BrSpontRomaSariGandumCokelat, string BrSpontRomaKelapaSandwich, string BrSpontBiskuat, string BrSpontBetter, string BrSpontBiskuatCoklatSusu, string BrSpontBiskuatEnergi, string BrSpontBiskuatEnergiCoklat, string BrSpontBiskuatSusu, string BrSpontOreo, string BrSpontSOLTwice, string BrSpontRomamalkistcoklat, string BrSpontTwice, string BrSpontBelvita, string BrAidRomaKelapa, string BrAidRomaMalkist, string BrAidSlaiOLai, string BrAidRomaMarieSusu, string BrAidRomaMalkistAbon, string BrAidRomaSariGandumCokelat, string BrAidRomaKelapaSandwich, string BrAidBiskuat, string BrAidBetter, string BrAidBiskuatCoklatSusu, string BrAidBiskuatEnergi, string BrAidBiskuatEnergiCoklat, string BrAidBiskuatSusu, string BrAidOreo, string BrAidSOLTwice, string BrAidRomamalkistcoklat, string BrAidTwice, string BrAidBelvita, string AdAidRomaKelapa, string AdAidRomaMalkist, string AdAidSlaiOLai, string AdAidRomaMarieSusu, string AdAidRomaMalkistAbon, string AdAidRomaSariGandumCokelat, string AdAidRomaKelapaSandwich, string AdAidBiskuat, string AdAidBetter, string AdAidBiskuatCoklatSusu, string AdAidBiskuatEnergi, string AdAidBiskuatEnergiCoklat, string AdAidBiskuatSusu, string AdAidOreo, string AdAidSOLTwice, string AdAidRomamalkistcoklat, string AdAidTwice, string AdAidBelvita, string CurConsRomaKelapa, string CurConsRomaMalkist, string CurConsSlaiOLai, string CurConsRomaMarieSusu, string CurConsRomaMalkistAbon, string CurConsRomaSariGandumCokelat, string CurConsRomaKelapaSandwich, string CurConsBiskuat, string CurConsBetter, string CurConsBiskuatCoklatSusu, string CurConsBiskuatEnergi, string CurConsBiskuatEnergiCoklat, string CurConsBiskuatSusu, string CurConsOreo, string CurConsSOLTwice, string CurConsRomamalkistcoklat, string CurConsTwice, string CurConsBelvita, string ConsLMRomaKelapa, string ConsLMRomaMalkist, string ConsLMSlaiOLai, string ConsLMRomaMarieSusu, string ConsLMRomaMalkistAbon, string ConsLMRomaSariGandumCokelat, string ConsLMRomaKelapaSandwich, string ConsLMBiskuat, string ConsLMBetter, string ConsLMBiskuatCoklatSusu, string ConsLMBiskuatEnergi, string ConsLMBiskuatEnergiCoklat, string ConsLMBiskuatSusu, string ConsLMOreo, string ConsLMSOLTwice, string ConsLMRomamalkistcoklat, string ConsLMTwice, string ConsLMBelvita, string BrTomNetKHONGGUAN, string BrTomNetROMASARIGANDUM, string BrTomNetROMACRACKERS, string BrTomNetKGCRACKERS, string BrTomNetSLAIOLAI, string BrSpontNetKHONGGUAN, string BrSpontNetROMASARIGANDUM, string BrSpontNetROMACRACKERS, string BrSpontNetKGCRACKERS, string BrSpontNetSLAIOLAI, string BrAidNetKHONGGUAN, string BrAidNetROMASARIGANDUM, string BrAidNetROMACRACKERS, string BrAidNetKGCRACKERS, string BrAidNetSLAIOLAI, string AdTomNetKHONGGUAN, string AdTomNetROMASARIGANDUM, string AdTomNetROMACRACKERS, string AdTomNetKGCRACKERS, string AdTomNetSLAIOLAI, string AdSpontNetKHONGGUAN, string AdSpontNetROMASARIGANDUM, string AdSpontNetROMACRACKERS, string AdSpontNetKGCRACKERS, string AdSpontNetSLAIOLAI, string AdAidNetKHONGGUAN, string AdAidNetROMASARIGANDUM, string AdAidNetROMACRACKERS, string AdAidNetKGCRACKERS, string AdAidNetSLAIOLAI, string NetFavBrandKhongGuan, string NetFavBrandRomaSariGandum, string NetFavBrandRomaCrackers, string NetFavBrandKGCrakers, string NetFavBrandSlaiOlai, string NetBumoKhongGuan, string NetBumoRomaSariGandum, string NetBumoRomaCrackers, string NetBumoKGCrakers, string NetBumoSlaiOlai, string NetConsuLMKhongGuan, string NetConsuLMRomaSariGandum, string NetConsuLMRomaCrackers, string NetConsuLMKGCrakers, string NetConsuLMSlaiOlai, string NetConCurKhongGuan, string NetConCurRomaSariGandum, string NetConCurRomaCrackers, string NetConCurKGCrakers, string NetConCurSlaiOlai, string AdSpontBisvitSelimut, string BrSpontBisvitSelimut, string BrAidBisvitSelimut, string AdAidBisvitSelimut, string CurConsBisvitSelimut, string ConsLMBisvitSelimut, string BrTomNetHATARI, string BrSpontNetHATARI, string BrAidNetHATARI, string AdTomNetHATARI, string AdSpontNetHATARI, string AdAidNetHATARI, string NetFavBrandHATARI, string NetBumoHATARI, string NetConsuLMHATARI, string NetConCurHATARI, string q294t1_1, string q294t1_2, string q294t1_3, string q294t1_4, string q294t1_5, string q294t2_1, string q294t2_2, string q294t2_3, string q294t2_4, string q294t2_5, string q295t1_1, string q295t1_2, string q295t1_3, string q295t1_4, string q295t1_5, string q295t1_6, string q295t2_1, string q295t2_2, string q295t2_3, string q295t2_4, string q295t2_5, string q295t2_6, string q296t1_1, string q296t1_2, string q296t1_3, string q296t1_4, string q296t1_5, string q296t2_1, string q296t2_2, string q296t2_3, string q296t2_4, string q296t2_5, string q297t1_1, string q297t1_2, string q297t1_3, string q297t1_4, string q297t1_5, string q297t2_1, string q297t2_2, string q297t2_3, string q297t2_4, string q297t2_5, string q298t1_1, string q298t1_2, string q298t1_3, string q298t1_4, string q298t1_5, string q298t1_6, string q298t1_7, string q298t2_1, string q298t2_2, string q298t2_3, string q298t2_4, string q298t2_5, string q298t2_6, string q298t2_7, string q299t1_1, string q299t1_2, string q299t1_3, string q299t1_4, string q299t1_5, string q299t1_6, string q299t3_1, string q299t3_2, string q299t3_3, string q299t3_4, string q299t3_5, string q299t3_6, string ConsP1WRomaKelapa, string ConsP1WRomaMalkist, string ConsP1WSlaiOLai, string ConsP1WRomaMarieSusu, string ConsP1WRomaMalkistAbon, string ConsP1WRomaSariGandumCokelat, string ConsP1WRomaKelapaSandwich, string ConsP1WBiskuat, string ConsP1WBetter, string ConsP1WBiskuatCoklatSusu, string ConsP1WBiskuatEnergi, string ConsP1WBiskuatEnergiCoklat, string ConsP1WBiskuatSusu, string ConsP1WOreo, string ConsP1WSOLTwice, string ConsP1WRomamalkistcoklat, string ConsP1WTwice, string ConsP1WBelvita, string ConsP1WBisvitSelimut, string ConsP1DRomaKelapa, string ConsP1DRomaMalkist, string ConsP1DSlaiOLai, string ConsP1DRomaMarieSusu, string ConsP1DRomaMalkistAbon, string ConsP1DRomaSariGandumCokelat, string ConsP1DRomaKelapaSandwich, string ConsP1DBiskuat, string ConsP1DBetter, string ConsP1DBiskuatCoklatSusu, string ConsP1DBiskuatEnergi, string ConsP1DBiskuatEnergiCoklat, string ConsP1DBiskuatSusu, string ConsP1DOreo, string ConsP1DSOLTwice, string ConsP1DRomamalkistcoklat, string ConsP1DTwice, string ConsP1DBelvita, string ConsP1DBisvitSelimut, string NetConsuP1WKhongGuan, string NetConsuP1WRomaSariGandum, string NetConsuP1WRomaCrackers, string NetConsuP1WKGCrakers, string NetConsuP1WSlaiOlai, string NetConsuP1WHATARI, string NetConsuP1DKhongGuan, string NetConsuP1DRomaSariGandum, string NetConsuP1DRomaCrackers, string NetConsuP1DKGCrakers, string NetConsuP1DSlaiOlai, string NetConsuP1DHATARI)
        {
            int i;
            connection.Open();
            //SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_YY_BI_temp  (UserID,Gender,MaritalStatus,Country,SurveyID,AttendedOn,Weight,SurveyPeriod,BrTom,AdTom,FavouriteBrand,Bumo,Location,AgeGroup,Ses,Period,AdSpontRomaKelapa,AdSpontRomaMalkist,AdSpontSlaiOLai,AdSpontRomaMarieSusu,AdSpontRomaMalkistAbon,AdSpontRomaSariGandumCokelat,AdSpontRomaKelapaSandwich,AdSpontBiskuat,AdSpontBetter,AdSpontBiskuatCoklatSusu,AdSpontBiskuatEnergi,AdSpontBiskuatEnergiCoklat,AdSpontBiskuatSusu,AdSpontOreo,AdSpontSOLTwice,AdSpontRomamalkistcoklat,AdSpontTwice,AdSpontBelvita,BrSpontRomaKelapa,BrSpontRomaMalkist,BrSpontSlaiOLai,BrSpontRomaMarieSusu,BrSpontRomaMalkistAbon,BrSpontRomaSariGandumCokelat,BrSpontRomaKelapaSandwich,BrSpontBiskuat,BrSpontBetter,BrSpontBiskuatCoklatSusu,BrSpontBiskuatEnergi,BrSpontBiskuatEnergiCoklat,BrSpontBiskuatSusu,BrSpontOreo,BrSpontSOLTwice,BrSpontRomamalkistcoklat,BrSpontTwice,BrSpontBelvita,BrAidRomaKelapa,BrAidRomaMalkist,BrAidSlaiOLai,BrAidRomaMarieSusu,BrAidRomaMalkistAbon,BrAidRomaSariGandumCokelat,BrAidRomaKelapaSandwich,BrAidBiskuat,BrAidBetter,BrAidBiskuatCoklatSusu,BrAidBiskuatEnergi,BrAidBiskuatEnergiCoklat,BrAidBiskuatSusu,BrAidOreo,BrAidSOLTwice,BrAidRomamalkistcoklat,BrAidTwice,BrAidBelvita,AdAidRomaKelapa,AdAidRomaMalkist,AdAidSlaiOLai,AdAidRomaMarieSusu,AdAidRomaMalkistAbon,AdAidRomaSariGandumCokelat,AdAidRomaKelapaSandwich,AdAidBiskuat,AdAidBetter,AdAidBiskuatCoklatSusu,AdAidBiskuatEnergi,AdAidBiskuatEnergiCoklat,AdAidBiskuatSusu,AdAidOreo,AdAidSOLTwice,AdAidRomamalkistcoklat,AdAidTwice,AdAidBelvita,CurConsRomaKelapa,CurConsRomaMalkist,CurConsSlaiOLai,CurConsRomaMarieSusu,CurConsRomaMalkistAbon,CurConsRomaSariGandumCokelat,CurConsRomaKelapaSandwich,CurConsBiskuat,CurConsBetter,CurConsBiskuatCoklatSusu,CurConsBiskuatEnergi,CurConsBiskuatEnergiCoklat,CurConsBiskuatSusu,CurConsOreo,CurConsSOLTwice,CurConsRomamalkistcoklat,CurConsTwice,CurConsBelvita,ConsL3MRomaKelapa,ConsL3MRomaMalkist,ConsL3MSlaiOLai,ConsL3MRomaMarieSusu,ConsL3MRomaMalkistAbon,ConsL3MRomaSariGandumCokelat,ConsL3MRomaKelapaSandwich,ConsL3MBiskuat,ConsL3MBetter,ConsL3MBiskuatCoklatSusu,ConsL3MBiskuatEnergi,ConsL3MBiskuatEnergiCoklat,ConsL3MBiskuatSusu,ConsL3MOreo,ConsL3MSOLTwice,ConsL3MRomamalkistcoklat,ConsL3MTwice,ConsL3MBelvita,BrTomNetKHONGGUAN,BrTomNetROMASARIGANDUM,BrTomNetROMACRACKERS,BrTomNetKGCRACKERS,BrTomNetSLAIOLAI,BrSpontNetKHONGGUAN,BrSpontNetROMASARIGANDUM,BrSpontNetROMACRACKERS,BrSpontNetKGCRACKERS,BrSpontNetSLAIOLAI,BrAidNetKHONGGUAN,BrAidNetROMASARIGANDUM,BrAidNetROMACRACKERS,BrAidNetKGCRACKERS,BrAidNetSLAIOLAI,AdTomNetKHONGGUAN,AdTomNetROMASARIGANDUM,AdTomNetROMACRACKERS,AdTomNetKGCRACKERS,AdTomNetSLAIOLAI,AdSpontNetKHONGGUAN,AdSpontNetROMASARIGANDUM,AdSpontNetROMACRACKERS,AdSpontNetKGCRACKERS,AdSpontNetSLAIOLAI,AdAidNetKHONGGUAN,AdAidNetROMASARIGANDUM,AdAidNetROMACRACKERS,AdAidNetKGCRACKERS,AdAidNetSLAIOLAI,NetFavBrandKhongGuan,NetFavBrandRomaSariGandum,NetFavBrandRomaCrackers,NetFavBrandKGCrakers,NetFavBrandSlaiOlai,NetBumoKhongGuan,NetBumoRomaSariGandum,NetBumoRomaCrackers,NetBumoKGCrakers,NetBumoSlaiOlai,NetConsuLMKhongGuan,NetConsuLMRomaSariGandum,NetConsuLMRomaCrackers,NetConsuLMKGCrakers,NetConsuLMSlaiOlai,NetConCurKhongGuan,NetConCurRomaSariGandum,NetConCurRomaCrackers,NetConCurKGCrakers,NetConCurSlaiOlai,BrTomBK,AdTomBK,FavouriteBrandBk,BumoBK,AdSpontBisvitSelimut,BrSpontBisvitSelimut,BrAidBisvitSelimut,AdAidBisvitSelimut,CurConsBisvitSelimut,ConsL3MBisvitSelimut,BrTomNetHATARI,BrSpontNetHATARI,BrAidNetHATARI,AdTomNetHATARI,AdSpontNetHATARI,AdAidNetHATARI,NetFavBrandHATARI,NetBumoHATARI,NetConsuLMHATARI,NetConCurHATARI,q294t1_1,q294t1_2,q294t1_3,q294t1_4,q294t1_5,q294t2_1,q294t2_2,q294t2_3,q294t2_4,q294t2_5,q295t1_1,q295t1_2,q295t1_3,q295t1_4,q295t1_5,q295t1_6,q295t2_1,q295t2_2,q295t2_3,q295t2_4,q295t2_5,q295t2_6,q296t1_1,q296t1_2,q296t1_3,q296t1_4,q296t1_5,q296t2_1,q296t2_2,q296t2_3,q296t2_4,q296t2_5,q297t1_1,q297t1_2,q297t1_3,q297t1_4,q297t1_5,q297t2_1,q297t2_2,q297t2_3,q297t2_4,q297t2_5,q298t1_1,q298t1_2,q298t1_3,q298t1_4,q298t1_5,q298t1_6,q298t1_7,q298t2_1,q298t2_2,q298t2_3,q298t2_4,q298t2_5,q298t2_6,q298t2_7,q299t1_1,q299t1_2,q299t1_3,q299t1_4,q299t1_5,q299t1_6,q299t3_1,q299t3_2,q299t3_3,q299t3_4,q299t3_5,q299t3_6,ConsP1WRomaKelapa,ConsP1WRomaMalkist,ConsP1WSlaiOLai,ConsP1WRomaMarieSusu,ConsP1WRomaMalkistAbon,ConsP1WRomaSariGandumCokelat,ConsP1WRomaKelapaSandwich,ConsP1WBiskuat,ConsP1WBetter,ConsP1WBiskuatCoklatSusu,ConsP1WBiskuatEnergi,ConsP1WBiskuatEnergiCoklat,ConsP1WBiskuatSusu,ConsP1WOreo,ConsP1WSOLTwice,ConsP1WRomamalkistcoklat,ConsP1WTwice,ConsP1WBelvita,ConsP1WBisvitSelimut,ConsP1DRomaKelapa,ConsP1DRomaMalkist,ConsP1DSlaiOLai,ConsP1DRomaMarieSusu,ConsP1DRomaMalkistAbon,ConsP1DRomaSariGandumCokelat,ConsP1DRomaKelapaSandwich,ConsP1DBiskuat,ConsP1DBetter,ConsP1DBiskuatCoklatSusu,ConsP1DBiskuatEnergi,ConsP1DBiskuatEnergiCoklat,ConsP1DBiskuatSusu,ConsP1DOreo,ConsP1DSOLTwice,ConsP1DRomamalkistcoklat,ConsP1DTwice,ConsP1DBelvita,ConsP1DBisvitSelimut,NetConsuP1WKhongGuan,NetConsuP1WRomaSariGandum,NetConsuP1WRomaCrackers,NetConsuP1WKGCrakers,NetConsuP1WSlaiOlai,NetConsuP1WHATARI,NetConsuP1DKhongGuan,NetConsuP1DRomaSariGandum,NetConsuP1DRomaCrackers,NetConsuP1DKGCrakers,NetConsuP1DSlaiOlai,NetConsuP1DHATARI) " + "VALUES('" + userID + "','" + Gender + "','" + MaritalStatus + "','" + Country + "','" + SurveyID + "','" + SurveyPeriod + "','" + Weight + "','" + SurveyPeriod + "','" + BrTom + "','" + AdTom + "','" + FavouriteBrand + "','" + Bumo + "','" + Location + "','" + AgeGroup + "','" + Ses + "','" + Period + "','" + AdSpontRomaKelapa + "','" + AdSpontRomaMalkist + "','" + AdSpontSlaiOLai + "','" + AdSpontRomaMarieSusu + "','" + AdSpontRomaMalkistAbon + "','" + AdSpontRomaSariGandumCokelat + "','" + AdSpontRomaKelapaSandwich + "','" + AdSpontBiskuat + "','" + AdSpontBetter + "','" + AdSpontBiskuatCoklatSusu + "','" + AdSpontBiskuatEnergi + "','" + AdSpontBiskuatEnergiCoklat + "','" + AdSpontBiskuatSusu + "','" + AdSpontOreo + "','" + AdSpontSOLTwice + "','" + AdSpontRomamalkistcoklat + "','" + AdSpontTwice + "','" + AdSpontBelvita + "','" + BrSpontRomaKelapa + "','" + BrSpontRomaMalkist + "','" + BrSpontSlaiOLai + "','" + BrSpontRomaMarieSusu + "','" + BrSpontRomaMalkistAbon + "','" + BrSpontRomaSariGandumCokelat + "','" + BrSpontRomaKelapaSandwich + "','" + BrSpontBiskuat + "','" + BrSpontBetter + "','" + BrSpontBiskuatCoklatSusu + "','" + BrSpontBiskuatEnergi + "','" + BrSpontBiskuatEnergiCoklat + "','" + BrSpontBiskuatSusu + "','" + BrSpontOreo + "','" + BrSpontSOLTwice + "','" + BrSpontRomamalkistcoklat + "','" + BrSpontTwice + "','" + BrSpontBelvita + "','" + BrAidRomaKelapa + "','" + BrAidRomaMalkist + "','" + BrAidSlaiOLai + "','" + BrAidRomaMarieSusu + "','" + BrAidRomaMalkistAbon + "','" + BrAidRomaSariGandumCokelat + "','" + BrAidRomaKelapaSandwich + "','" + BrAidBiskuat + "','" + BrAidBetter + "','" + BrAidBiskuatCoklatSusu + "','" + BrAidBiskuatEnergi + "','" + BrAidBiskuatEnergiCoklat + "','" + BrAidBiskuatSusu + "','" + BrAidOreo + "','" + BrAidSOLTwice + "','" + BrAidRomamalkistcoklat + "','" + BrAidTwice + "','" + BrAidBelvita + "','" + AdAidRomaKelapa + "','" + AdAidRomaMalkist + "','" + AdAidSlaiOLai + "','" + AdAidRomaMarieSusu + "','" + AdAidRomaMalkistAbon + "','" + AdAidRomaSariGandumCokelat + "','" + AdAidRomaKelapaSandwich + "','" + AdAidBiskuat + "','" + AdAidBetter + "','" + AdAidBiskuatCoklatSusu + "','" + AdAidBiskuatEnergi + "','" + AdAidBiskuatEnergiCoklat + "','" + AdAidBiskuatSusu + "','" + AdAidOreo + "','" + AdAidSOLTwice + "','" + AdAidRomamalkistcoklat + "','" + AdAidTwice + "','" + AdAidBelvita + "','" + CurConsRomaKelapa + "','" + CurConsRomaMalkist + "','" + CurConsSlaiOLai + "','" + CurConsRomaMarieSusu + "','" + CurConsRomaMalkistAbon + "','" + CurConsRomaSariGandumCokelat + "','" + CurConsRomaKelapaSandwich + "','" + CurConsBiskuat + "','" + CurConsBetter + "','" + CurConsBiskuatCoklatSusu + "','" + CurConsBiskuatEnergi + "','" + CurConsBiskuatEnergiCoklat + "','" + CurConsBiskuatSusu + "','" + CurConsOreo + "','" + CurConsSOLTwice + "','" + CurConsRomamalkistcoklat + "','" + CurConsTwice + "','" + CurConsBelvita + "','" + ConsLMRomaKelapa + "','" + ConsLMRomaMalkist + "','" + ConsLMSlaiOLai + "','" + ConsLMRomaMarieSusu + "','" + ConsLMRomaMalkistAbon + "','" + ConsLMRomaSariGandumCokelat + "','" + ConsLMRomaKelapaSandwich + "','" + ConsLMBiskuat + "','" + ConsLMBetter + "','" + ConsLMBiskuatCoklatSusu + "','" + ConsLMBiskuatEnergi + "','" + ConsLMBiskuatEnergiCoklat + "','" + ConsLMBiskuatSusu + "','" + ConsLMOreo + "','" + ConsLMSOLTwice + "','" + ConsLMRomamalkistcoklat + "','" + ConsLMTwice + "','" + ConsLMBelvita + "','" + BrTomNetKHONGGUAN + "','" + BrTomNetROMASARIGANDUM + "','" + BrTomNetROMACRACKERS + "','" + BrTomNetKGCRACKERS + "','" + BrTomNetSLAIOLAI + "','" + BrSpontNetKHONGGUAN + "','" + BrSpontNetROMASARIGANDUM + "','" + BrSpontNetROMACRACKERS + "','" + BrSpontNetKGCRACKERS + "','" + BrSpontNetSLAIOLAI + "','" + BrAidNetKHONGGUAN + "','" + BrAidNetROMASARIGANDUM + "','" + BrAidNetROMACRACKERS + "','" + BrAidNetKGCRACKERS + "','" + BrAidNetSLAIOLAI + "','" + AdTomNetKHONGGUAN + "','" + AdTomNetROMASARIGANDUM + "','" + AdTomNetROMACRACKERS + "','" + AdTomNetKGCRACKERS + "','" + AdTomNetSLAIOLAI + "','" + AdSpontNetKHONGGUAN + "','" + AdSpontNetROMASARIGANDUM + "','" + AdSpontNetROMACRACKERS + "','" + AdSpontNetKGCRACKERS + "','" + AdSpontNetSLAIOLAI + "','" + AdAidNetKHONGGUAN + "','" + AdAidNetROMASARIGANDUM + "','" + AdAidNetROMACRACKERS + "','" + AdAidNetKGCRACKERS + "','" + AdAidNetSLAIOLAI + "','" + NetFavBrandKhongGuan + "','" + NetFavBrandRomaSariGandum + "','" + NetFavBrandRomaCrackers + "','" + NetFavBrandKGCrakers + "','" + NetFavBrandSlaiOlai + "','" + NetBumoKhongGuan + "','" + NetBumoRomaSariGandum + "','" + NetBumoRomaCrackers + "','" + NetBumoKGCrakers + "','" + NetBumoSlaiOlai + "','" + NetConsuLMKhongGuan + "','" + NetConsuLMRomaSariGandum + "','" + NetConsuLMRomaCrackers + "','" + NetConsuLMKGCrakers + "','" + NetConsuLMSlaiOlai + "','" + NetConCurKhongGuan + "','" + NetConCurRomaSariGandum + "','" + NetConCurRomaCrackers + "','" + NetConCurKGCrakers + "','" + NetConCurSlaiOlai + "','" + BrTom + "','" + AdTom + "','" + FavouriteBrand + "','" + Bumo + "','" + AdSpontBisvitSelimut + "','" + BrSpontBisvitSelimut + "','" + BrAidBisvitSelimut + "','" + AdAidBisvitSelimut + "','" + CurConsBisvitSelimut + "','" + ConsLMBisvitSelimut + "','" + BrTomNetHATARI + "','" + BrSpontNetHATARI + "','" + BrAidNetHATARI + "','" + AdTomNetHATARI + "','" + AdSpontNetHATARI + "','" + AdAidNetHATARI + "','" + NetFavBrandHATARI + "','" + NetBumoHATARI + "','" + NetConsuLMHATARI + "','" + NetConCurHATARI + "','" + q294t1_1 + "','" + q294t1_2 + "','" + q294t1_3 + "','" + q294t1_4 + "','" + q294t1_5 + "','" + q294t2_1 + "','" + q294t2_2 + "','" + q294t2_3 + "','" + q294t2_4 + "','" + q294t2_5 + "','" + q295t1_1 + "','" + q295t1_2 + "','" + q295t1_3 + "','" + q295t1_4 + "','" + q295t1_5 + "','" + q295t1_6 + "','" + q295t2_1 + "','" + q295t2_2 + "','" + q295t2_3 + "','" + q295t2_4 + "','" + q295t2_5 + "','" + q295t2_6 + "','" + q296t1_1 + "','" + q296t1_2 + "','" + q296t1_3 + "','" + q296t1_4 + "','" + q296t1_5 + "','" + q296t2_1 + "','" + q296t2_2 + "','" + q296t2_3 + "','" + q296t2_4 + "','" + q296t2_5 + "','" + q297t1_1 + "','" + q297t1_2 + "','" + q297t1_3 + "','" + q297t1_4 + "','" + q297t1_5 + "','" + q297t2_1 + "','" + q297t2_2 + "','" + q297t2_3 + "','" + q297t2_4 + "','" + q297t2_5 + "','" + q298t1_1 + "','" + q298t1_2 + "','" + q298t1_3 + "','" + q298t1_4 + "','" + q298t1_5 + "','" + q298t1_6 + "','" + q298t1_7 + "','" + q298t2_1 + "','" + q298t2_2 + "','" + q298t2_3 + "','" + q298t2_4 + "','" + q298t2_5 + "','" + q298t2_6 + "','" + q298t2_7 + "','" + q299t1_1 + "','" + q299t1_2 + "','" + q299t1_3 + "','" + q299t1_4 + "','" + q299t1_5 + "','" + q299t1_6 + "','" + q299t3_1 + "','" + q299t3_2 + "','" + q299t3_3 + "','" + q299t3_4 + "','" + q299t3_5 + "','" + q299t3_6 + "','" + ConsP1WRomaKelapa + "' ,'" + ConsP1WRomaMalkist + "' ,'" + ConsP1WSlaiOLai + "' ,'" + ConsP1WRomaMarieSusu + "' ,'" + ConsP1WRomaMalkistAbon + "' ,'" + ConsP1WRomaSariGandumCokelat + "' ,'" + ConsP1WRomaKelapaSandwich + "' ,'" + ConsP1WBiskuat + "' ,'" + ConsP1WBetter + "' ,'" + ConsP1WBiskuatCoklatSusu + "' ,'" + ConsP1WBiskuatEnergi + "' ,'" + ConsP1WBiskuatEnergiCoklat + "' ,'" + ConsP1WBiskuatSusu + "' ,'" + ConsP1WOreo + "' ,'" + ConsP1WSOLTwice + "' ,'" + ConsP1WRomamalkistcoklat + "' ,'" + ConsP1WTwice + "' ,'" + ConsP1WBelvita + "','" + ConsP1WBisvitSelimut + "' ,'" + ConsP1DRomaKelapa + "' ,'" + ConsP1DRomaMalkist + "' ,'" + ConsP1DSlaiOLai + "' ,'" + ConsP1DRomaMarieSusu + "' ,'" + ConsP1DRomaMalkistAbon + "' ,'" + ConsP1DRomaSariGandumCokelat + "' ,'" + ConsP1DRomaKelapaSandwich + "' ,'" + ConsP1DBiskuat + "' ,'" + ConsP1DBetter + "' ,'" + ConsP1DBiskuatCoklatSusu + "' ,'" + ConsP1DBiskuatEnergi + "' ,'" + ConsP1DBiskuatEnergiCoklat + "' ,'" + ConsP1DBiskuatSusu + "' ,'" + ConsP1DOreo + "' ,'" + ConsP1DSOLTwice + "' ,'" + ConsP1DRomamalkistcoklat + "' ,'" + ConsP1DTwice + "' ,'" + ConsP1DBelvita + "' ,'" + ConsP1DBisvitSelimut + "' ,'" + NetConsuP1WKhongGuan + "' ,'" + NetConsuP1WRomaSariGandum + "' ,'" + NetConsuP1WRomaCrackers + "' ,'" + NetConsuP1WKGCrakers + "' ,'" + NetConsuP1WSlaiOlai + "' ,'" + NetConsuP1WHATARI + "' ,'" + NetConsuP1DKhongGuan + "' ,'" + NetConsuP1DRomaSariGandum + "' ,'" + NetConsuP1DRomaCrackers + "' ,'" + NetConsuP1DKGCrakers + "' ,'" + NetConsuP1DSlaiOlai + "' ,'" + NetConsuP1DHATARI + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                i = 1;
            }
            catch (Exception ex)
            {

                connection.Close();
                i = 0;
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        
        internal void insert_Dashboard_values_bus_bi(string userID, int SurveyID, string SurveyPeriod, string Period, string q142ft2_1, string q142ft2_2, string q142ft2_3, string q142ft2_4, string q142ft2_5, string q142ft2_8, string q142ft2_12, string q142ft2_13, string q142ft2_14, string q142ft2_18, string q294t1_1, string q294t1_2, string q294t1_3, string q294t1_4, string q294t1_5, string q294t2_1, string q294t2_2, string q294t2_3, string q294t2_4, string q294t2_5, string q295t1_1, string q295t1_2, string q295t1_3, string q295t1_4, string q295t1_5, string q295t1_6, string q295t2_1, string q295t2_2, string q295t2_3, string q295t2_4, string q295t2_5, string q295t2_6, string q296t1_1, string q296t1_2, string q296t1_3, string q296t1_4, string q296t1_5, string q296t2_1, string q296t2_2, string q296t2_3, string q296t2_4, string q296t2_5, string q297t1_1, string q297t1_2, string q297t1_3, string q297t1_4, string q297t1_5, string q297t2_1, string q297t2_2, string q297t2_3, string q297t2_4, string q297t2_5, string q298t1_1, string q298t1_2, string q298t1_3, string q298t1_4, string q298t1_5, string q298t1_6, string q298t1_7, string q298t2_1, string q298t2_2, string q298t2_3, string q298t2_4, string q298t2_5, string q298t2_6, string q298t2_7, string q299t1_1, string q299t1_2, string q299t1_3, string q299t1_4, string q299t1_5, string q299t1_6, string q299t3_1, string q299t3_2, string q299t3_3, string q299t3_4, string q299t3_5, string q299t3_6)
        {
            int i;
            connection.Open();
            //SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_YY_Biscuit_br_BI_temp  (UserID,SurveyID,SurveyPeriod,Period,q142ft2_1, q142ft2_2, q142ft2_3, q142ft2_4, q142ft2_5, q142ft2_8, q142ft2_12, q142ft2_13, q142ft2_14, q142ft2_18,q294t1_1,q294t1_2,q294t1_3,q294t1_4,q294t1_5,q294t2_1,q294t2_2,q294t2_3,q294t2_4,q294t2_5,q295t1_1,q295t1_2,q295t1_3,q295t1_4,q295t1_5,q295t1_6,q295t2_1,q295t2_2,q295t2_3,q295t2_4,q295t2_5,q295t2_6,q296t1_1,q296t1_2,q296t1_3,q296t1_4,q296t1_5,q296t2_1,q296t2_2,q296t2_3,q296t2_4,q296t2_5,q297t1_1,q297t1_2,q297t1_3,q297t1_4,q297t1_5,q297t2_1,q297t2_2,q297t2_3,q297t2_4,q297t2_5,q298t1_1,q298t1_2,q298t1_3,q298t1_4,q298t1_5,q298t1_6,q298t1_7,q298t2_1,q298t2_2,q298t2_3,q298t2_4,q298t2_5,q298t2_6,q298t2_7,q299t1_1,q299t1_2,q299t1_3,q299t1_4,q299t1_5,q299t1_6,q299t3_1,q299t3_2,q299t3_3,q299t3_4,q299t3_5,q299t3_6) " + "VALUES('" + userID + "','" + SurveyID + "','" + SurveyPeriod + "','" + Period + "','" + q142ft2_1 + "','" + q142ft2_2 + "','" + q142ft2_3 + "','" + q142ft2_4 + "','" + q142ft2_5 + "','" + q142ft2_8 + "','" + q142ft2_12 + "','" + q142ft2_13 + "','" + q142ft2_14 + "','" + q142ft2_18 + "','" + q294t1_1 + "','" + q294t1_2 + "','" + q294t1_3 + "','" + q294t1_4 + "','" + q294t1_5 + "','" + q294t2_1 + "','" + q294t2_2 + "','" + q294t2_3 + "','" + q294t2_4 + "','" + q294t2_5 + "','" + q295t1_1 + "','" + q295t1_2 + "','" + q295t1_3 + "','" + q295t1_4 + "','" + q295t1_5 + "','" + q295t1_6 + "','" + q295t2_1 + "','" + q295t2_2 + "','" + q295t2_3 + "','" + q295t2_4 + "','" + q295t2_5 + "','" + q295t2_6 + "','" + q296t1_1 + "','" + q296t1_2 + "','" + q296t1_3 + "','" + q296t1_4 + "','" + q296t1_5 + "','" + q296t2_1 + "','" + q296t2_2 + "','" + q296t2_3 + "','" + q296t2_4 + "','" + q296t2_5 + "','" + q297t1_1 + "','" + q297t1_2 + "','" + q297t1_3 + "','" + q297t1_4 + "','" + q297t1_5 + "','" + q297t2_1 + "','" + q297t2_2 + "','" + q297t2_3 + "','" + q297t2_4 + "','" + q297t2_5 + "','" + q298t1_1 + "','" + q298t1_2 + "','" + q298t1_3 + "','" + q298t1_4 + "','" + q298t1_5 + "','" + q298t1_6 + "','" + q298t1_7 + "','" + q298t2_1 + "','" + q298t2_2 + "','" + q298t2_3 + "','" + q298t2_4 + "','" + q298t2_5 + "','" + q298t2_6 + "','" + q298t2_7 + "','" + q299t1_1 + "','" + q299t1_2 + "','" + q299t1_3 + "','" + q299t1_4 + "','" + q299t1_5 + "','" + q299t1_6 + "','" + q299t3_1 + "','" + q299t3_2 + "','" + q299t3_3 + "','" + q299t3_4 + "','" + q299t3_5 + "','" + q299t3_6 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                i = 1;
            }
            catch (Exception ex)
            {

                connection.Close();
                i = 0;
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_Dashboard_NewBrand(string userID, int SurveyID, string SurveyPeriod, string AdSpontBisvitSelimut, string BrSpontBisvitSelimut, string BrAidBisvitSelimut, string AdAidBisvitSelimut, string CurConsBisvitSelimut, string ConsLMBisvitSelimut, string BrTomNetHATARI, string BrSpontNetHATARI, string BrAidNetHATARI, string AdTomNetHATARI, string AdSpontNetHATARI, string AdAidNetHATARI, string NetFavBrandHATARI, string NetBumoHATARI, string NetConsuLMHATARI, string NetConCurHATARI)
        {

            int i;
            connection.Open();
            //SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_YY_Biscuit_NewBrand  (UserID,SurveyID,SURVEY_PERIOD,AdSpontBisvitSelimut,BrSpontBisvitSelimut,BrAidBisvitSelimut,AdAidBisvitSelimut,CurConsBisvitSelimut,ConsLMBisvitSelimut,BrTomNetHATARI,BrSpontNetHATARI,BrAidNetHATARI,AdTomNetHATARI,AdSpontNetHATARI,AdAidNetHATARI,NetFavBrandHATARI,NetBumoHATARI,NetConsuLMHATARI,NetConCurHATARI) " + "VALUES('" + userID + "','" + SurveyID + "','" + SurveyPeriod + "','" + AdSpontBisvitSelimut + "','" + BrSpontBisvitSelimut + "','" + BrAidBisvitSelimut + "','" + AdAidBisvitSelimut + "','" + CurConsBisvitSelimut + "','" + ConsLMBisvitSelimut + "','" + BrTomNetHATARI + "','" + BrSpontNetHATARI + "','" + BrAidNetHATARI + "','" + AdTomNetHATARI + "','" + AdSpontNetHATARI + "','" + AdAidNetHATARI + "','" + NetFavBrandHATARI + "','" + NetBumoHATARI + "','" + NetConsuLMHATARI + "','" + NetConCurHATARI + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                i = 1;
            }
            catch (Exception ex)
            {

                connection.Close();
                i = 0;
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }
    }

}
