using System;
using System.Collections.Generic;

namespace LinkedIn;

public class Job
{
    public string JobId { get; }
    public string Description { get; }
    public string CompanyName { get; }
    public DateTime LastDate { get; }

    public Job(string jobId, string description, string companyName, DateTime lastDate)
    {
        JobId = jobId;
        Description = description;
        CompanyName = companyName;
        LastDate = lastDate;
    }
}