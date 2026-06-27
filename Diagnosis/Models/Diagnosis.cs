using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyurvedaClinicSystem.Models; // Links your UI form to data models folder


namespace AyurvedaClinicSystem.Models
{
    public abstract class MedicalRecord
    {
        private int patientId;
        private DateTime recordDate;

        public int PatientID
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public DateTime RecordDate
        {
            get { return recordDate; }
            set { recordDate = value; }
        }

        public abstract string GenerateSummaryText();
    }
    public class Diagnosis : MedicalRecord
    {
        private int diagnosisId;
        private string symptoms;
        private string pulseDiagnosis;
        private string doctorNotes;
        private string diagnosisResult;

        public int DiagnosisID
        {
            get { return diagnosisId; }
            set { diagnosisId = value; }
        }

        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }
        public string PulseDiagnosis
        {
            get { return pulseDiagnosis; }
            set { pulseDiagnosis = value; }
        }

        public string DoctorNotes
        {
            get { return doctorNotes; }
            set { doctorNotes = value; }
        }

        public string DiagnosisResult
        {
            get { return diagnosisResult; }
            set { diagnosisResult = value; }
        }
        public override string GenerateSummaryText()
        {
            return $"Diagnosis ID: {DiagnosisID}\nSymptoms: {Symptoms}\nResult: {DiagnosisResult}";
        }
    }
}
