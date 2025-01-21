using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_Personnel : tDALTable
    {
        public XVar Id;
        public XVar Name;
        public XVar Integrity;
        public XVar Proficiency;
        public XVar CivilServiceQualification;
        public XVar Rank;
        public XVar TrainingDetails;
        public static void Init()
        {
            XVar dalTablePersonnel = XVar.Array();
            dalTablePersonnel["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTablePersonnel["Name"] = new XVar("type", 200, "varname", "Name", "name", "Name", "autoInc", "0");
            dalTablePersonnel["Integrity"] = new XVar("type", 11, "varname", "Integrity", "name", "Integrity", "autoInc", "0");
            dalTablePersonnel["Proficiency"] = new XVar("type", 11, "varname", "Proficiency", "name", "Proficiency", "autoInc", "0");
            dalTablePersonnel["CivilServiceQualification"] = new XVar("type", 11, "varname", "CivilServiceQualification", "name", "CivilServiceQualification", "autoInc", "0");
            dalTablePersonnel["Rank"] = new XVar("type", 200, "varname", "Rank", "name", "Rank", "autoInc", "0");
            dalTablePersonnel["TrainingDetails"] = new XVar("type", 200, "varname", "TrainingDetails", "name", "TrainingDetails", "autoInc", "0");
	        dalTablePersonnel.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_Personnel"] = dalTablePersonnel;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_Personnel()
        {
            			this.m_TableName = "dbo.Personnel";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_Personnel";
        }
    }
}