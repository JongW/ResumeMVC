using System.Text.Json;
using ResumeWebsite.Models;

namespace ResumeWebsite.Services;

public interface IResumeService
{
    Task<Resume> GetResumeAsync(CancellationToken ct = default);
}

public sealed class ResumeService : IResumeService
{
    private readonly IWebHostEnvironment _env;

    public ResumeService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public async Task<Resume> GetResumeAsync(CancellationToken ct = default)
    {
        var path = Path.Combine(_env.ContentRootPath, "Data", "resume.json");

        if (!File.Exists(path))
            throw new FileNotFoundException("resume.json not found", path);

        var json = await File.ReadAllTextAsync(path, ct);

        var resume = JsonSerializer.Deserialize<Resume>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return resume ?? throw new InvalidOperationException("Failed to deserialize resume.json");
    }
}
