namespace CertificationManager.Shared.Resources
{
    public static class SharedResources
    {
        public const string ApplicationName = "ApplicationName";
        public const string AppConfigAppLabel = "TripSvc";
        public const string AppName = "Trip";
        public const string AppConfigCommonLabel = "Common";
        public const string AppConfigSentinel = "App:Sentinel";
        public const string TmsEventsKey = "TmsEvents";

        public const string ElasticSearchLogUri = "ElasticSearch:Log:Uri";
        public const string ElasticSearchLogApiKeyAuthId = "ElasticSearch:Log:ApiKeyAuth:Id";
        public const string ElasticSearchLogApiKeyAuthKey = "ElasticSearch:Log:ApiKeyAuth:Key";
        public const string LogLevel = "Logging:LogLevel";

        public const string AppConfigConnectionString = "AppConfig:ConnectionString";
        public const string AppConfigEndpoint = "AppConfig:Endpoint";
        public const string AppConfigEnableEventConsumer = "AppConfig:EnableEventConsumer";
        public const string InstrumentationKey = "ApplicationInsights:InstrumentationKey";
        public const string CorsMethodsKey = "Security:CorsAllowedMethods";
        public const string CorsOriginsKey = "Security:CorsAllowedOrigins";

        public const string ChargerEventsBroker = "ChargerBroker";

        public const string Authorization = "Authorization";
        public const string PCMIlerApiKey = "ExternalApi:PCMilerApiKey";
        public const string PCMilerETAQuery = "ExternalApi:PCMilerQuery";
        public const string ControllerNamePropertyName = "ControllerName";
        public const string ActionNamePropertyName = "ControllerActionName";


        public const string BorderStatusNotSubmitted = "NOT SUBMITTED";
        public const string BorderStatusNew = "NEW";
        public const string BorderStatusSubmitted = "SUBMITTED";
        public const string BorderStatusAccepted = "ACCEPTED";
        public const string BorderStatusRejected = "REJECTED";

        public const string LogFormat = "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | CorrelationId: {CorrelationId} | ThreadId: {ThreadId} | ClientIp: {ClientIp} | ControllerName: {ControllerName} | ActionName: {ControllerActionName} |Level: {Level:u3} | {Message:lj}{NewLine}{Exception}]";

        public const string AuditIdLogPropertyName = "DbAuditEntityId";
        public const string AuditNameLogPropertyName = "DbAuditEntityName";
        public const string HandlerRequestId = "HandlerRequestId";
    }
}
