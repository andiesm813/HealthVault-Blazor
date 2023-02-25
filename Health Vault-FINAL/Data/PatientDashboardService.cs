using System.Net.Http.Json;

namespace Health_Vault_FINAL.PatientDashboard
{
    public class PatientDashboardService: IPatientDashboardService
    {
        private readonly HttpClient _http;

        public PatientDashboardService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<WeightType>?> GetWeight()
        {
            return await this._http.GetFromJsonAsync<List<WeightType>>("https://excel2json.io/api/share/b8fb8833-7e2c-4a84-e611-08daf8ae6744");
        }

        public async Task<List<HeartRateType>?> GetHeartRate()
        {
            return await this._http.GetFromJsonAsync<List<HeartRateType>>("https://excel2json.io/api/share/43cfd6ae-a6db-42b5-e610-08daf8ae6744");
        }

        public async Task<List<BPSystolicDiastolicType>?> GetBPSystolicDiastolic()
        {
            return await this._http.GetFromJsonAsync<List<BPSystolicDiastolicType>>("https://excel2json.io/api/share/16761321-7913-4d05-e616-08daf8ae6744");
        }

        public async Task<List<GlucoseType>?> GetGlucose()
        {
            return await this._http.GetFromJsonAsync<List<GlucoseType>>("https://excel2json.io/api/share/e1b52986-0c42-4ee1-e617-08daf8ae6744");
        }

        public async Task<List<TotalCholesterolType>?> GetTotalCholesterol()
        {
            return await this._http.GetFromJsonAsync<List<TotalCholesterolType>>("https://excel2json.io/api/share/2f36bf07-125a-4301-e612-08daf8ae6744");
        }

        public async Task<List<CholesterolHDLLDLType>?> GetCholesterolHDLLDL()
        {
            return await this._http.GetFromJsonAsync<List<CholesterolHDLLDLType>>("https://excel2json.io/api/share/a1863711-3edb-42ae-e613-08daf8ae6744");
        }
    }
}