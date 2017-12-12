namespace reportsystemwebapi.Models
{
    public class DetailReports
    {
        public int ParentCycleID {get;set;}
        public int TestReportID {get;set;}
        public string FeatureName {get;set;} 
        public string ScenarioName {get;set;}
        public string StepName {get;set;}
        public string Exception {get;set;}
        public string Result {get;set;}
    }
}
