namespace Health_Vault_FINAL.PatientDashboard
{
    public class MockPatientDashboardService : IPatientDashboardService
    {
        public Task<List<WeightType>?> GetWeight()
        {
            return Task.FromResult<List<WeightType>?>(new());
        }

        public Task<List<HeartRateType>?> GetHeartRate()
        {
            return Task.FromResult<List<HeartRateType>?>(new());
        }

        public Task<List<BPSystolicDiastolicType>?> GetBPSystolicDiastolic()
        {
            return Task.FromResult<List<BPSystolicDiastolicType>?>(new());
        }

        public Task<List<GlucoseType>?> GetGlucose()
        {
            return Task.FromResult<List<GlucoseType>?>(new());
        }

        public Task<List<TotalCholesterolType>?> GetTotalCholesterol()
        {
            return Task.FromResult<List<TotalCholesterolType>?>(new());
        }

        public Task<List<CholesterolHDLLDLType>?> GetCholesterolHDLLDL()
        {
            return Task.FromResult<List<CholesterolHDLLDLType>?>(new());
        }
    }
}