namespace task_3;

public class Doctor
{
    string fullName;
    string specialty;
    int experience;
    // constructors
    public Doctor()
    { }
    public Doctor(string name, string _specialty)
    {
        fullName = name;
        specialty = _specialty;
    }
    public Doctor(string name, string _specialty, int _experience)
    {
        fullName = name;
        specialty = _specialty;
        experience = _experience;
    }
    // methods
    public string TreatPatient(string patientName)
    {
        return $"{fullName}, {specialty}, is treating a patient named {patientName}";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{fullName} is performing a medical examination for the patient named {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{fullName} prescribes {medication} for the patient named {patientName}";
    }

    public void SetExperience(int year)
    {
        experience = year;
    }
    public int GetExperience()
    {
        return experience;
    }

}
