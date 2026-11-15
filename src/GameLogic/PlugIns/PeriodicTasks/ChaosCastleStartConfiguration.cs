// <copyright file="ChaosCastleStartConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.PeriodicTasks;

/// <summary>
/// The chaos castle start configuration.
/// </summary>
public class ChaosCastleStartConfiguration : MiniGameStartConfiguration
{
    /// <summary>
    /// Gets the default configuration for chaos castle.
    /// </summary>
    public static ChaosCastleStartConfiguration Default =>
        new()
        {
            PreStartMessageDelay = TimeSpan.Zero,
            EntranceOpenedMessage = "混沌城堡入口已开放，{0} 分钟后关闭。",
            EntranceClosedMessage = "混沌城堡入口已关闭。",
            TaskDuration = TimeSpan.FromMinutes(15),
            Timetable = PeriodicTaskConfiguration.GenerateTimeSequence(TimeSpan.FromMinutes(240), startLimit: new TimeOnly(2, 0)).ToList(),
        };
}