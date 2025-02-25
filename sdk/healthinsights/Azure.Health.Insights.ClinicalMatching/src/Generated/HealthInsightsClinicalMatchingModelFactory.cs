// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Model factory for models. </summary>
    public static partial class HealthInsightsClinicalMatchingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.TrialMatcherResult"/>. </summary>
        /// <param name="jobId"> A processing job identifier. </param>
        /// <param name="createdDateTime"> The date and time when the processing job was created. </param>
        /// <param name="expirationDateTime"> The date and time when the processing job is set to expire. </param>
        /// <param name="lastUpdateDateTime"> The date and time when the processing job was last updated. </param>
        /// <param name="status"> The status of the processing job. </param>
        /// <param name="errors"> An array of errors, if any errors occurred during the processing job. </param>
        /// <param name="results"> The inference results for the Trial Matcher request. </param>
        /// <returns> A new <see cref="ClinicalMatching.TrialMatcherResult"/> instance for mocking. </returns>
        public static TrialMatcherResult TrialMatcherResult(Guid jobId = default, DateTimeOffset createdDateTime = default, DateTimeOffset expirationDateTime = default, DateTimeOffset lastUpdateDateTime = default, JobStatus status = default, IEnumerable<ResponseError> errors = null, TrialMatcherResults results = null)
        {
            errors ??= new List<ResponseError>();

            return new TrialMatcherResult(jobId, createdDateTime, expirationDateTime, lastUpdateDateTime, status, errors?.ToList(), results);
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.TrialMatcherResults"/>. </summary>
        /// <param name="patients"> Results for the patients given in the request. </param>
        /// <param name="modelVersion"> The version of the model used for inference, expressed as the model date. </param>
        /// <param name="knowledgeGraphLastUpdateDate"> The date when the clinical trials knowledge graph was last updated. </param>
        /// <returns> A new <see cref="ClinicalMatching.TrialMatcherResults"/> instance for mocking. </returns>
        public static TrialMatcherResults TrialMatcherResults(IEnumerable<TrialMatcherPatientResult> patients = null, string modelVersion = null, DateTimeOffset? knowledgeGraphLastUpdateDate = null)
        {
            patients ??= new List<TrialMatcherPatientResult>();

            return new TrialMatcherResults(patients?.ToList(), modelVersion, knowledgeGraphLastUpdateDate);
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.TrialMatcherPatientResult"/>. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <param name="neededClinicalInfo"> Clinical information which is needed to provide better trial matching results for the patient. </param>
        /// <returns> A new <see cref="ClinicalMatching.TrialMatcherPatientResult"/> instance for mocking. </returns>
        public static TrialMatcherPatientResult TrialMatcherPatientResult(string id = null, IEnumerable<TrialMatcherInference> inferences = null, IEnumerable<ExtendedClinicalCodedElement> neededClinicalInfo = null)
        {
            inferences ??= new List<TrialMatcherInference>();
            neededClinicalInfo ??= new List<ExtendedClinicalCodedElement>();

            return new TrialMatcherPatientResult(id, inferences?.ToList(), neededClinicalInfo?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.TrialMatcherInference"/>. </summary>
        /// <param name="type"> The type of the Trial Matcher inference. </param>
        /// <param name="value"> The value of the inference, as relevant for the given inference type. </param>
        /// <param name="description"> The description corresponding to the inference value. </param>
        /// <param name="confidenceScore"> Confidence score for this inference. </param>
        /// <param name="evidence"> The evidence corresponding to the inference value. </param>
        /// <param name="id"> The identifier of the clinical trial. </param>
        /// <param name="source"> Possible sources of a clinical trial. </param>
        /// <param name="metadata"> Trial data which is of interest to the potential participant. </param>
        /// <returns> A new <see cref="ClinicalMatching.TrialMatcherInference"/> instance for mocking. </returns>
        public static TrialMatcherInference TrialMatcherInference(TrialMatcherInferenceType type = default, string value = null, string description = null, float? confidenceScore = null, IEnumerable<TrialMatcherInferenceEvidence> evidence = null, string id = null, ClinicalTrialSource? source = null, ClinicalTrialMetadata metadata = null)
        {
            evidence ??= new List<TrialMatcherInferenceEvidence>();

            return new TrialMatcherInference(type, value, description, confidenceScore, evidence?.ToList(), id, source, metadata);
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.TrialMatcherInferenceEvidence"/>. </summary>
        /// <param name="eligibilityCriteriaEvidence"> A piece of evidence from the eligibility criteria text of a clinical trial. </param>
        /// <param name="patientDataEvidence"> A piece of evidence from a clinical note (text document). </param>
        /// <param name="patientInfoEvidence">
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </param>
        /// <param name="importance"> A value indicating how important this piece of evidence is for the inference. </param>
        /// <returns> A new <see cref="ClinicalMatching.TrialMatcherInferenceEvidence"/> instance for mocking. </returns>
        public static TrialMatcherInferenceEvidence TrialMatcherInferenceEvidence(string eligibilityCriteriaEvidence = null, ClinicalNoteEvidence patientDataEvidence = null, ClinicalCodedElement patientInfoEvidence = null, float? importance = null)
        {
            return new TrialMatcherInferenceEvidence(eligibilityCriteriaEvidence, patientDataEvidence, patientInfoEvidence, importance);
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.ClinicalNoteEvidence"/>. </summary>
        /// <param name="id"> The identifier of the document containing the evidence. </param>
        /// <param name="text"> The actual text span which is evidence for the inference. </param>
        /// <param name="offset"> The start index of the evidence text span in the document (0 based). </param>
        /// <param name="length"> The length of the evidence text span. </param>
        /// <returns> A new <see cref="ClinicalMatching.ClinicalNoteEvidence"/> instance for mocking. </returns>
        public static ClinicalNoteEvidence ClinicalNoteEvidence(string id = null, string text = null, int offset = default, int length = default)
        {
            return new ClinicalNoteEvidence(id, text, offset, length);
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalMatching.ExtendedClinicalCodedElement"/>. </summary>
        /// <param name="system"> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </param>
        /// <param name="code"> The code within the given clinical coding system. </param>
        /// <param name="name"> The name of this coded concept in the coding system. </param>
        /// <param name="value"> A value associated with the code within the given clinical coding system. </param>
        /// <param name="semanticType"> The [UMLS semantic type](https://www.nlm.nih.gov/research/umls/META3_current_semantic_types.html) associated with the coded concept. </param>
        /// <param name="category"> The bio-medical category related to the coded concept, e.g. Diagnosis, Symptom, Medication, Examination. </param>
        /// <returns> A new <see cref="ClinicalMatching.ExtendedClinicalCodedElement"/> instance for mocking. </returns>
        public static ExtendedClinicalCodedElement ExtendedClinicalCodedElement(string system = null, string code = null, string name = null, string value = null, string semanticType = null, string category = null)
        {
            return new ExtendedClinicalCodedElement(system, code, name, value, semanticType, category);
        }
    }
}
