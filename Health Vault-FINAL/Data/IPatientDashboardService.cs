namespace Health_Vault_FINAL.PatientDashboard
{
    public interface IPatientDashboardService
    {
        Task<List<WeightType>?> GetWeight();

        Task<List<HeartRateType>?> GetHeartRate();

        Task<List<BPSystolicDiastolicType>?> GetBPSystolicDiastolic();

        Task<List<GlucoseType>?> GetGlucose();

        Task<List<TotalCholesterolType>?> GetTotalCholesterol();

        Task<List<CholesterolHDLLDLType>?> GetCholesterolHDLLDL();
    }
}