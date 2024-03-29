﻿using System;
using System.Collections.Generic;

namespace JiraWriter.Model
{
    public class JiraIssue
    {
        public string Key { get; private set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string[] Labels { get; set; }
        public string Team { get; set; }
        public DateTime InProgressDate { get; set; }
        public DateTime DoneDate { get; set; }
        public List<JiraState> JiraStates { get; set; } = new List<JiraState>();
        public List<TimeInState> TimeInStates { get; set; } = new List<TimeInState>();
        public int? CycleTime { get; set; }
        public int? BlockedTime { get; set; }

        public bool HasMoreChangeHistory { get; set; }

        public List<Block> Blocks { get; set; } = new List<Block>();

        public JiraIssue(string key, string description)
        {
            Key = key;
            Description = description;
        }
    }
}
