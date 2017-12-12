namespace reportsystemwebapi.Models
{
    using System;

    public class TestCycle
    {
        public int TestCycleID {get;set;}
        public string AUTName {get;set;}
        public string ExecutedBy {get;set;} 
        public string RequestedBy {get;set;} 
        
        public int BuildNo{get;set;}
        public string ApplicationVersion {get;set;}
        public DateTime DateOfExecution {get;set;}
        public string TestType {get;set;}
        public string MachineName {get;set;}
        public int RowId {get;set;}
        public string ReportZip {get;set;}
    }
}
