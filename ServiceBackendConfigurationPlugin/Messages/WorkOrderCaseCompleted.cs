namespace ServiceBackendConfigurationPlugin.Messages;

public class WorkOrderCaseCompleted(int? caseId, int? microtingUId, int? checkId, int? siteUId)
{
    public int? CaseId { get;} = caseId;
    public int? MicrotingUId { get; } = microtingUId;
    public int? CheckId { get; } = checkId;
    public int? SiteUId { get; } = siteUId;
}