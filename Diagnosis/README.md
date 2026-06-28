# Diagnosis & Clinical Evaluation Module

## Coursework Assessment: CS107.3 - Object-Oriented Programming with C#
**Developed By:** Adithi Hansika  
**Role:** Doctor Dashboard - Diagnosis Sub-System

---

## Module Architecture & Components
This subsystem is built following layered architecture and clean Separation of Concerns :
1. **Presentation Layer (`DiagnosisForm.cs`):** A modern, flat UI styled to match the team's medical theme dashboard. Handles search lookups, full CRUD validation routines, and physical printing workflows.
2. **Infrastructure Layer (`Database/DBConnection.cs`):** Manages secure system state channels and session initialization pathways pointing to the `clinicmanagement` port schema.
3. **OOP Blueprint Models (`Models/Diagnosis.cs` & `Models/Patient.cs`):** Structured records handling clinical properties.
---

## Advanced OOP Pillars Implemented
This project fulfills core OOP concepts:
* **Abstraction:** Implements the abstract base template `MedicalRecord` to standardize future medical modules (e.g., prescriptions, labs).
* **Inheritance:** The `Diagnosis` child class inherits standard parameters like `PatientID` and `RecordDate` seamlessly from `MedicalRecord`.
* **Encapsulation:** Uses private data fields protected securely behind public getter/setter property blocks.
* **Polymorphism:** Method overriding used on `GenerateSummaryText()` to resolve custom layout rendering styles dynamically at runtime.
---

