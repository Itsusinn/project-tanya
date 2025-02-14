﻿using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Tanya.Core.Extensions;

namespace Tanya.Game.Apex.Feature.Aim
{
    public class Config
    {
        private readonly IConfigurationSection _config;

        #region Constructors

        public Config(IConfiguration config)
        {
            _config = config.GetSection(typeof(Config).Namespace);
        }

        #endregion

        #region Properties

        [JsonPropertyName("distance")]
        public int Distance => _config.GetProperty<int>();


        [JsonPropertyName("aimDistance")]
        public int AimDistance => _config.GetProperty<int>();

        [JsonPropertyName("lockTime")]
        public int LockTime => _config.GetProperty<int>();

        [JsonPropertyName("pitchAngle")]
        public int PitchAngle => _config.GetProperty<int>();

        [JsonPropertyName("pitchDeadzone")]
        public float PitchDeadzone => _config.GetProperty<float>();

        [JsonPropertyName("pitchSpeed")]
        public float PitchSpeed => _config.GetProperty<float>();

        [JsonPropertyName("recoil")]
        public float Recoil => _config.GetProperty<float>();

        [JsonPropertyName("releaseTime")]
        public int ReleaseTime => _config.GetProperty<int>();

        [JsonPropertyName("yawAngle")]
        public int YawAngle => _config.GetProperty<int>();

        [JsonPropertyName("yawDeadzone")]
        public float YawDeadzone => _config.GetProperty<float>();

        [JsonPropertyName("yawSpeed")]
        public float YawSpeed => _config.GetProperty<float>();


        [JsonPropertyName("friendlyLock")]
        public bool FriendlyLock => _config.GetProperty<bool>();

        [JsonPropertyName("ignoreKockDown")]
        public bool IgnoreKockDown => _config.GetProperty<bool>();

        [JsonPropertyName("lockWhenSpeed")]
        public bool LockWhenSpeed => _config.GetProperty<bool>();
        #endregion
    }
}