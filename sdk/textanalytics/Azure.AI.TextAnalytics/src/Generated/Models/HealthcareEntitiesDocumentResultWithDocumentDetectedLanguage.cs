// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage. </summary>
    internal partial class HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage : HealthcareEntitiesDocumentResult
    {
        /// <summary> Initializes a new instance of HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="entities"/> or <paramref name="relations"/> is null. </exception>
        public HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<HealthcareEntityInternal> entities, IEnumerable<HealthcareRelationInternal> relations) : base(id, warnings, entities, relations)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));
            Argument.AssertNotNull(relations, nameof(relations));
        }

        /// <summary> Initializes a new instance of HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="fhirBundle"> JSON bundle containing a FHIR compatible object for consumption in other Healthcare tools. For additional information see https://www.hl7.org/fhir/overview.html. </param>
        /// <param name="detectedLanguage"> If &apos;language&apos; is set to &apos;auto&apos; for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </param>
        internal HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<HealthcareEntityInternal> entities, IList<HealthcareRelationInternal> relations, IDictionary<string, object> fhirBundle, string detectedLanguage) : base(id, warnings, statistics, entities, relations, fhirBundle)
        {
            DetectedLanguage = detectedLanguage;
        }

        /// <summary> If &apos;language&apos; is set to &apos;auto&apos; for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </summary>
        public string DetectedLanguage { get; set; }
    }
}
