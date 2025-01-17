﻿using System.Collections.Generic;

namespace Plogon.Repo;

/// <summary>
/// Class defining state for the target plugin repository.
/// </summary>
public class State
{
    public State()
    {
        this.Channels = new Dictionary<string, Channel>();
    }

    public class Channel
    {
        public Channel()
        {
            this.Plugins = new Dictionary<string, PluginState>();
        }
        
        public class PluginState
        {
            public string BuiltCommit { get; set; }
        }
        
        public IDictionary<string, PluginState> Plugins { get; set; }
    }
    
    public IDictionary<string, Channel> Channels { get; set; }
}