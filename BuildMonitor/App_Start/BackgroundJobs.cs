using BuildMonitor.Jobs;
using Hangfire;

namespace BuildMonitor
{
    public class BackgroundJobs
    {
        public static void Start()
        {
            RecurringJob.AddOrUpdate(
                JobIds.RefreshBuilds,
                () => RefreshBuildsJob.Refresh(),
                Cron.Minutely);

            RecurringJob.AddOrUpdate(
                JobIds.RefreshProjects,
                () => RefreshProjectsJob.Refresh(),
                Cron.Minutely);
        }
    }
}