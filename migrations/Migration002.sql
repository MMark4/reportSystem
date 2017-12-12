use SystemReport;

CREATE TABLE TestCycles (
    TestCycleID int,
    AUTName varchar(255),
    ExecutedBy varchar(255),
    RequestedBy varchar(255),
    BuildNo int,
    ApplicationVersion varchar(255),
    DateOfExecution date,
    TestType varchar(255),
    MachineName varchar(255),
    RowId int,
    ReportZip varchar(255),
    CONSTRAINT PK_TestCycles PRIMARY KEY (TestCycleID)
);

CREATE TABLE DetailReports (
    ParentCycleID int,
    TestReportID int,
    FeatureName varchar(255),
    ScenarioName varchar(255),
    StepName varchar(255),
    Exception varchar(255),
    Result varchar(255),
    CONSTRAINT PK_DetailReports PRIMARY KEY (TestReportID),
    FOREIGN KEY (TestReportID) REFERENCES TestCycles(TestCycleID)
);

CREATE TABLE FailureReport (
    FailureReportID int,
    FailureDetails varchar(255),
    Screenshot varchar(255),
    CONSTRAINT PK_FailureReport PRIMARY KEY (FailureReportID),
    FOREIGN KEY (FailureReportID) REFERENCES DetailReports(TestReportID)
);