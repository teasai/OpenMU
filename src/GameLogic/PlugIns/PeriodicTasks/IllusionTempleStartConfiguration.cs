// <copyright file="IllusionTempleStartConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.PeriodicTasks;

/// <summary>
/// The Illusion temple start configuration.
/// </summary>
public class IllusionTempleStartConfiguration : MiniGameStartConfiguration
{
    /// <summary>
    /// Gets the default configuration for Illusion Temple.
    /// </summary>
    public static IllusionTempleStartConfiguration Default =>
        new()
        {
            PreStartMessageDelay = TimeSpan.Zero,
            EntranceOpenedMessage = "幻影神殿入口已开放，{0} 分钟后关闭。",
            EntranceClosedMessage = "幻影神殿入口已关闭。",
            TaskDuration = TimeSpan.FromMinutes(15),
            Timetable = PeriodicTaskConfiguration.GenerateTimeSequence(TimeSpan.FromMinutes(120)).ToList(),
        };
}