using System;
using Serilog.Configuration;
using Serilog.Enrichers.TraceIdentifier.Enrichers;

namespace Serilog
{
    /// <summary>
    /// Extends <see cref="LoggerConfiguration"/> to add enrichers for the current TraceIdentifier/>.
    /// capabilities.
    /// </summary>
    public static class TraceIdentifierLoggerConfigurationExtensions
    {
        /// <summary>
        /// Enrich log events with a TraceIdentifier property containing the current TraceIdentifier/>.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithTraceIdentifier(
           this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<TraceIdentifierEnricher>();
        }
    }
}