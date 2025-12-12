using System.Diagnostics.CodeAnalysis;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace ModularMonolith.Host.Seeding;

public class SeedService(
    ILogger<SeedService> logger)
{

    public async Task SeedDataAsync()
    {
	    Randomizer.Seed = new Random(4503);


        logger.LogInformation("Starting data seeding...");

		// TODO: Implement data seeding logic here

		logger.LogInformation("Data seeding completed");
    }



}
