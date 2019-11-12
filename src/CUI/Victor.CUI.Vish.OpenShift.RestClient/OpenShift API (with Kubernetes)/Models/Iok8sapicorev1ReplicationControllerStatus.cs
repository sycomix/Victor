﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Victor.CUI.Vish.OpenShift.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// ReplicationControllerStatus represents the current status of a
    /// replication controller.
    /// </summary>
    public partial class Iok8sapicorev1ReplicationControllerStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ReplicationControllerStatus class.
        /// </summary>
        public Iok8sapicorev1ReplicationControllerStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ReplicationControllerStatus class.
        /// </summary>
        public Iok8sapicorev1ReplicationControllerStatus(int replicas, int? availableReplicas = default(int?), IList<Iok8sapicorev1ReplicationControllerCondition> conditions = default(IList<Iok8sapicorev1ReplicationControllerCondition>), int? fullyLabeledReplicas = default(int?), long? observedGeneration = default(long?), int? readyReplicas = default(int?))
        {
            AvailableReplicas = availableReplicas;
            Conditions = conditions;
            FullyLabeledReplicas = fullyLabeledReplicas;
            ObservedGeneration = observedGeneration;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
        }

        /// <summary>
        /// The number of available replicas (ready for at least
        /// minReadySeconds) for this replication controller.
        /// </summary>
        [JsonProperty(PropertyName = "availableReplicas")]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Represents the latest available observations of a replication
        /// controller's current state.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Iok8sapicorev1ReplicationControllerCondition> Conditions { get; set; }

        /// <summary>
        /// The number of pods that have labels matching the labels of the pod
        /// template of the replication controller.
        /// </summary>
        [JsonProperty(PropertyName = "fullyLabeledReplicas")]
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>
        /// ObservedGeneration reflects the generation of the most recently
        /// observed replication controller.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// The number of ready replicas for this replication controller.
        /// </summary>
        [JsonProperty(PropertyName = "readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Replicas is the most recently oberved number of replicas. More
        /// info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int Replicas { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Conditions != null)
            {
                foreach (var element in this.Conditions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}