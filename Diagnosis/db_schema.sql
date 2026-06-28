USE clinicmanagement;
SELECT * FROM patients;
SELECT * FROM diagnosis;
USE clinicmanagement;

-- Step 1: Delete the current broken table structure
DROP TABLE IF EXISTS diagnosis;

-- Step 2: Rebuild it with AUTO_INCREMENT so it generates its own IDs automatically
CREATE TABLE diagnosis (
    DiagnosisID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT,
    Symptoms TEXT,
    PulseDiagnosis TEXT,
    DoctorNotes TEXT,
    DiagnosisResult TEXT,
    DiagnosisDate DATE
);
SELECT * FROM Diagnosis;