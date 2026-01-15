namespace CMS_BusinessLayer
{
    public class clsExamination
    {
        enum enMode { Add, Update}
        enMode Mode;

        public int ExaminationID { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
        public string Prescription { get; set; }

        public clsExamination()
        {
            Mode = enMode.Add;
            ExaminationID = -1;
            Symptoms = string.Empty;
            Diagnosis = string.Empty;
            Notes = string.Empty;
            Prescription = string.Empty;
        }

        clsExamination(int examinationID, string symptoms, string diagnosis, string notes, string prescription)
        {
            Mode = enMode.Update;
            ExaminationID = examinationID;
            Symptoms = symptoms;
            Diagnosis = diagnosis;
            Notes = notes;
            Prescription = prescription;
        }

        public static clsExamination Find(int ExaminationID)
        {
            string Symptoms = string.Empty;
            string Diagnosis = string.Empty;
            string Notes = string.Empty;
            string Prescription = string.Empty;

            if (CMS_DataLayer.clsExamination.GetExaminationByID(ExaminationID, ref Symptoms, ref Diagnosis, ref Notes, ref Prescription))
            {
                return new clsExamination(ExaminationID, Symptoms, Diagnosis, Notes, Prescription);
            }
            return null;
        }

        bool _Add()
        {
            ExaminationID = CMS_DataLayer.clsExamination.AddNewExamination(Symptoms, Diagnosis, Notes, Prescription);
            return (ExaminationID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsExamination.UpdateExamination(ExaminationID, Symptoms, Diagnosis, Notes, Prescription);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteExamination(int ExaminationID)
        {
            return CMS_DataLayer.clsExamination.DeleteExamination(ExaminationID);
        }
    }
}
