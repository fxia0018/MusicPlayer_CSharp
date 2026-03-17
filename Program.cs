using static SplashKitSDK.SplashKit;

string userInput;
bool isRunning = true;
bool paused = false;

WriteLine("Welcome Jace's music player, you can listen Jace's favourite songs");
while (isRunning)
{
    WriteLine();
    Write("\"start\" to choose songs, \n\"p\" to pause/resume, \n\"quit\" to exit\n");
    WriteLine();
    WriteLine("You can also type 'q' to quit at any time.");
    WriteLine("Press any key to continue...");

    userInput = ReadLine();

    if (userInput == "quit")
    {
        if (MusicPlaying()) StopMusic();
        WriteLine("Thank you for using Jace's music player!");
        isRunning = false;
        break;
    }
    else if (userInput == "p")
    {
        if (MusicPlaying())
        {
            PauseMusic();
            WriteLine("Music paused");
        }
        else
        {
            ResumeMusic();
            WriteLine("Music resumed");
        }

    }

    else if (userInput == "start")
    {
        WriteLine("1. Kokoro no Ame\n2. Itsudemo Hohoemi wo\n3. Hello!\n4. Feel the rain");
        Write("Type 1, 2, 3 or 4 to play the song: ");
    }
    else
    {
        WriteLine("Invalid input, please type 'start', 'q' or 'quit'.");
        continue;
    }

    string songChoice = ReadLine();
    string musicName = "";
    int delayTime = 0;

    if (songChoice == "1")
    {
        musicName = "Kokoro no Ame"; delayTime = 216000;
    }

    else if (songChoice == "2")
    {
        musicName = "Itsudemo Hohoemi wo"; delayTime = 235000;
    }

    else if (songChoice == "3")
    {
        musicName = "hello"; delayTime = 160000;
    }

    else if (songChoice == "4")
    {
        musicName = "rain"; delayTime = 214000;
    }

    else
    {
        WriteLine("Invalid song choice!"); continue;
    }

    LoadMusic(musicName, musicName + ".ogg");
    PlayMusic(musicName);

    int elapsed = 0;
    while (MusicPlaying() && elapsed < delayTime)
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.P)
            {
                if (paused)
                {
                    ResumeMusic();
                    WriteLine("Music resumed");
                    paused = false;
                }
                else
                {
                    PauseMusic();
                    WriteLine("Music paused");
                    paused = true;
                }
            }
            else if (key == ConsoleKey.Q)
            {
                StopMusic();
                isRunning = false;
                break;
            }
        }

        ProcessEvents();
        Delay(100);
        elapsed += 100;
    }

    FadeMusicOut(2000);
}

// 正在为我的 GitHub 主页收割小鲨鱼勋章