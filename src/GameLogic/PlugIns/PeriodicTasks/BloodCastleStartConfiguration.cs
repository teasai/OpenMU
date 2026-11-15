// <copyright file="BloodCastleStartConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.PeriodicTasks;

/// <summary>
/// The blood castle start configuration.
/// </summary>
public class BloodCastleStartConfiguration : MiniGameStartConfiguration
{
    /// <summary>
    /// Gets the default configuration for blood castle.
    /// </summary>
    public static BloodCastleStartConfiguration Default =>
        new()
        {
            PreStartMessageDelay = TimeSpan.Zero,
            EntranceOpenedMessage = "血色城堡入口已开放，{0} 分钟后关闭。",
            EntranceClosedMessage = "血色城堡入口已关闭。",
            TaskDuration = TimeSpan.FromMinutes(20),
            Timetable = GenerateTimeSequence(TimeSpan.FromMinutes(240), startLimit: new TimeOnly(1, 0)).ToList(),
        };
}