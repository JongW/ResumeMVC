using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ResumeWebsite.Models
{
    public class Resume
    {
        [JsonPropertyName("personalDetails")]
        public PersonalDetails PersonalDetails { get; set; } = new();

        [JsonPropertyName("professionalSummary")]
        public string ProfessionalSummary { get; set; } = string.Empty;

        [JsonPropertyName("workExperience")]
        public List<WorkExperience> WorkExperience { get; set; } = new();

        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; } = new();

        [JsonPropertyName("education")]
        public List<Education> Education { get; set; } = new();

        [JsonPropertyName("skills")]
        public List<SkillCategory> Skills { get; set; } = new();
    }

    public class PersonalDetails
    {
        [JsonPropertyName("fullName")]
        public string FullName { get; set; } = string.Empty;

        [JsonPropertyName("phone")]
        public string Phone { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("github")]
        public string Github { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;
    }

    public class WorkExperience
    {
        [JsonPropertyName("company")]
        public string Company { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonPropertyName("employmentPeriod")]
        public EmploymentPeriod EmploymentPeriod { get; set; } = new();

        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; } = string.Empty;

        [JsonPropertyName("responsibilities")]
        public List<string> Responsibilities { get; set; } = new();
    }

    public class EmploymentPeriod
    {
        // Start year is an int in your JSON
        [JsonPropertyName("startYear")]
        public int StartYear { get; set; }

        // End year can be "Present" or a year, so model as string
        [JsonPropertyName("endYear")]
        public string EndYear { get; set; } = "Present";
    }

    public class Project
    {
        [JsonPropertyName("projectName")]
        public string ProjectName { get; set; } = string.Empty;

        // Optional: present in some projects
        [JsonPropertyName("category")]
        public string? Category { get; set; }

        // Optional: present in some projects
        [JsonPropertyName("technologies")]
        public List<string>? Technologies { get; set; }

        [JsonPropertyName("details")]
        public List<string> Details { get; set; } = new();
    }

    public class Education
    {
        [JsonPropertyName("institution")]
        public string Institution { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonPropertyName("degree")]
        public string Degree { get; set; } = string.Empty;

        [JsonPropertyName("major")]
        public string Major { get; set; } = string.Empty;

        [JsonPropertyName("studyPeriod")]
        public StudyPeriod StudyPeriod { get; set; } = new();
    }

    public class StudyPeriod
    {
        [JsonPropertyName("startYear")]
        public int StartYear { get; set; }

        [JsonPropertyName("endYear")]
        public int EndYear { get; set; }
    }

    public class Skills
    {
        [JsonPropertyName("skills")]
        public List<SkillCategory> Categories { get; set; } = new();
    }

    public class SkillCategory
    {
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        [JsonPropertyName("items")]
        public List<SkillItem> Items { get; set; } = new();
    }
    public class SkillItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
