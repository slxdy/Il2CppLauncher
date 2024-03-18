﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Il2CppLauncher;

internal unsafe static class Program
{
    private static ModLogger logger = new("Il2CppLauncher");
    [NotNull] internal static GameInfo? gameInfo = null;

    private static int Main(string[] args)
    {
        var currentExePath = Process.GetCurrentProcess().MainModule?.FileName;
        if (currentExePath == null)
            return -1;

        if (args.Length >= 1)
        {
            var gamePath = args[0];
            if (File.Exists(gamePath))
            {
                gamePath = Path.GetDirectoryName(gamePath);
            }

            if (Directory.Exists(gamePath))
            {
                gameInfo = GameInfo.Read(gamePath);
                if (gameInfo != null)
                {
                    var gameArgs = new string[args.Length - 1];
                    Array.Copy(args, 1, gameArgs, 0, gameArgs.Length);

                    return StartGame(gameArgs);
                }
                else
                {
                    logger.Log($"No valid Unity game found at: '{gamePath}'", "red");
                }
            }
            else
            {
                logger.Log($"Could not find the game directory at: '{gamePath}'", "red");
            }
        }

        logger.Log("To launch Steam games through the mod loader, right click on your game in the Steam library, ");
        logger.Log("go to <color=green>Properties -> General -> Launch Options</color>.");
        logger.Log("Set the launch options to:");
        logger.Log($"\"{currentExePath}\" %command%", "green");
        logger.Log();
        logger.Log($"To run a game manually, run in the console:");
        logger.Log($"\"{currentExePath}\" \"Path/To/Game/Directory\"", "green");

        return 0;
    }

    private static int StartGame(string[] args)
    {
        logger.Log($"Game Exe: '{gameInfo.GameExePath}'");
        logger.Log($"Unity Version: '{gameInfo.UnityVersion}'");

        Directory.SetCurrentDirectory(gameInfo.GameDirectory);
        ModuleSpoofer.Spoof(gameInfo.GameExePath);

        return UnityPlayer.Start(args);
    }
}
